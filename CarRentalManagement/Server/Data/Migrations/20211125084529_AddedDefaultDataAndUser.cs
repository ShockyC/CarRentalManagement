using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "86fbbeae-d9ab-476b-b004-05ef51a39a53", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "a6546581-f90b-4dd2-8113-251691e6d8c1", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "3afb065f-1557-4a88-abde-89738d5c7af5", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAELphzsTIJnk1Efk0+5/vP/Ua2bcRBvhu6dr16r1BwJ137BRRqRjJqXYx2Rq9ThspOg==", null, false, "4474a352-0dc3-4826-bb73-67823c9e4c22", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 25, 16, 45, 28, 72, DateTimeKind.Local).AddTicks(4459), new DateTime(2021, 11, 25, 16, 45, 28, 73, DateTimeKind.Local).AddTicks(6154), "Black", "System" },
                    { 2, "System", new DateTime(2021, 11, 25, 16, 45, 28, 73, DateTimeKind.Local).AddTicks(7623), new DateTime(2021, 11, 25, 16, 45, 28, 73, DateTimeKind.Local).AddTicks(7631), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 25, 16, 45, 28, 76, DateTimeKind.Local).AddTicks(7826), new DateTime(2021, 11, 25, 16, 45, 28, 76, DateTimeKind.Local).AddTicks(7849), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 11, 25, 16, 45, 28, 76, DateTimeKind.Local).AddTicks(7856), new DateTime(2021, 11, 25, 16, 45, 28, 76, DateTimeKind.Local).AddTicks(7857), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 25, 16, 45, 28, 76, DateTimeKind.Local).AddTicks(2919), new DateTime(2021, 11, 25, 16, 45, 28, 76, DateTimeKind.Local).AddTicks(2947), "3 Series", "System" },
                    { 2, "System", new DateTime(2021, 11, 25, 16, 45, 28, 76, DateTimeKind.Local).AddTicks(2952), new DateTime(2021, 11, 25, 16, 45, 28, 76, DateTimeKind.Local).AddTicks(2953), "X5", "System" },
                    { 3, "System", new DateTime(2021, 11, 25, 16, 45, 28, 76, DateTimeKind.Local).AddTicks(2955), new DateTime(2021, 11, 25, 16, 45, 28, 76, DateTimeKind.Local).AddTicks(2956), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 11, 25, 16, 45, 28, 76, DateTimeKind.Local).AddTicks(2957), new DateTime(2021, 11, 25, 16, 45, 28, 76, DateTimeKind.Local).AddTicks(2959), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
