import { AdminService } from "@admin/services/admin.service";
import { CommonModule } from "@angular/common";
import { Component, inject, Input, OnInit } from "@angular/core";
import { RouterLink } from "@angular/router";
import { ConfirmPopupComponent } from "@core";
import { ApiResponseComponent } from "@core/components/controls/api-response/api-response.component";
import { ErrorListComponent } from "@core/components/controls/error-list/error-list.component";
import { RoutePipe } from "@routing";
import { ConfirmationService } from "primeng/api";
import { ButtonModule } from "primeng/button";
import { CardModule } from "primeng/card";
import { TableModule } from "primeng/table";
import { forkJoin, map, Observable } from "rxjs";
import { RoleViewModel } from "./role-view-model";

@Component({
  standalone: true,
  templateUrl: "./role.component.html",
  imports: [
    CommonModule,
    CardModule,
    TableModule,
    ButtonModule,
    RouterLink,
    RoutePipe,
    ErrorListComponent,
    ApiResponseComponent,
    ConfirmPopupComponent,
  ],
})
export class RoleComponent implements OnInit {
  #adminService = inject(AdminService);
  #confirmationService = inject(ConfirmationService);

  @Input() role!: string;

  header = "Loading role...";
  subHeader = "";
  errors: string[] = [];

  viewModel$ = new Observable<RoleViewModel>();

  ngOnInit() {
    this.#refreshRole();
  }

  #refreshRole() {
    this.viewModel$ = forkJoin([this.#adminService.getRole(this.role), this.#adminService.getUsersInRole(this.role)]).pipe(
      map(([role, users]) => {
        this.header = `Manage Users In Role: ${role.displayName}`;
        this.subHeader = role.description;

        return <RoleViewModel>{
          role,
          users,
        };
      })
    );
  }

  removeUserFromRole(event: any, userId: string) {
    this.errors = [];

    this.#confirmationService.confirm({
      header: "Confirm Role Removal",
      message: `Are you sure that you want to remove this role membership?`,
      target: event.target,
      key: userId,
      accept: () => {
        this.#adminService.removeUserFromRole(userId, this.role).subscribe({
          next: () => this.#refreshRole(),
          error: response => (this.errors = response.errorMessages),
        });
      },
    });
  }
}
