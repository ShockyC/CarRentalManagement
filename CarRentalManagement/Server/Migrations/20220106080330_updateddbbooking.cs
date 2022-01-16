using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class updateddbbooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "6228c2e1-78c3-4716-9c92-ebc927768cd2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "7157daf4-62b9-4866-919f-ac97b21edbf2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4d5a5ea-0e2f-42ca-a343-e8f7b8af07a8", "AQAAAAEAACcQAAAAEMLvMiEMk7+Ovyfxwiw1x7SvtrnyjGzgGl7xP3x0D4vsAV3Gbs0MXR6iBnHl2bayow==", "6fe99360-a995-43d8-8e70-1e9c979f877c" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 3, 29, 819, DateTimeKind.Local).AddTicks(6937), new DateTime(2022, 1, 6, 16, 3, 29, 820, DateTimeKind.Local).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 3, 29, 820, DateTimeKind.Local).AddTicks(9003), new DateTime(2022, 1, 6, 16, 3, 29, 820, DateTimeKind.Local).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 3, 29, 823, DateTimeKind.Local).AddTicks(6663), new DateTime(2022, 1, 6, 16, 3, 29, 823, DateTimeKind.Local).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 3, 29, 823, DateTimeKind.Local).AddTicks(6677), new DateTime(2022, 1, 6, 16, 3, 29, 823, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 3, 29, 823, DateTimeKind.Local).AddTicks(2065), new DateTime(2022, 1, 6, 16, 3, 29, 823, DateTimeKind.Local).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 3, 29, 823, DateTimeKind.Local).AddTicks(2101), new DateTime(2022, 1, 6, 16, 3, 29, 823, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 3, 29, 823, DateTimeKind.Local).AddTicks(2104), new DateTime(2022, 1, 6, 16, 3, 29, 823, DateTimeKind.Local).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 3, 29, 823, DateTimeKind.Local).AddTicks(2108), new DateTime(2022, 1, 6, 16, 3, 29, 823, DateTimeKind.Local).AddTicks(2109) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "abc695dd-5bd9-40ff-85bf-c5dfed1f80ff");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "1f3f9c16-6925-47bd-9bbc-6d6193eb973e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4c7a3ed-b796-4ffe-998c-929edb5a0c59", "AQAAAAEAACcQAAAAEHBDhq9HnqJ0/D+Mvot12qfUGJIA0EL9WGf5gD1qNlTfpNKj5OQT7tmgFN4oiV1XWQ==", "59a94967-cb9f-4896-b570-ffb70d745e56" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 15, 8, 18, 527, DateTimeKind.Local).AddTicks(2841), new DateTime(2022, 1, 3, 15, 8, 18, 528, DateTimeKind.Local).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 15, 8, 18, 528, DateTimeKind.Local).AddTicks(4430), new DateTime(2022, 1, 3, 15, 8, 18, 528, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 15, 8, 18, 530, DateTimeKind.Local).AddTicks(4159), new DateTime(2022, 1, 3, 15, 8, 18, 530, DateTimeKind.Local).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 15, 8, 18, 530, DateTimeKind.Local).AddTicks(4171), new DateTime(2022, 1, 3, 15, 8, 18, 530, DateTimeKind.Local).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 15, 8, 18, 530, DateTimeKind.Local).AddTicks(498), new DateTime(2022, 1, 3, 15, 8, 18, 530, DateTimeKind.Local).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 15, 8, 18, 530, DateTimeKind.Local).AddTicks(528), new DateTime(2022, 1, 3, 15, 8, 18, 530, DateTimeKind.Local).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 15, 8, 18, 530, DateTimeKind.Local).AddTicks(531), new DateTime(2022, 1, 3, 15, 8, 18, 530, DateTimeKind.Local).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 15, 8, 18, 530, DateTimeKind.Local).AddTicks(534), new DateTime(2022, 1, 3, 15, 8, 18, 530, DateTimeKind.Local).AddTicks(535) });
        }
    }
}
