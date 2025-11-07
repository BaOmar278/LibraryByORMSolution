using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryByORM.Migrations
{
    /// <inheritdoc />
    public partial class FixTransactionDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Books_bookId",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Branches_BranchId",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_LibraryMembers_memberId",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_LibraryStaffs_staffId",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction");

            migrationBuilder.RenameTable(
                name: "Transaction",
                newName: "Transactions");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_staffId",
                table: "Transactions",
                newName: "IX_Transactions_staffId");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_memberId",
                table: "Transactions",
                newName: "IX_Transactions_memberId");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_BranchId",
                table: "Transactions",
                newName: "IX_Transactions_BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_bookId",
                table: "Transactions",
                newName: "IX_Transactions_bookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Books_bookId",
                table: "Transactions",
                column: "bookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Branches_BranchId",
                table: "Transactions",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_LibraryMembers_memberId",
                table: "Transactions",
                column: "memberId",
                principalTable: "LibraryMembers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_LibraryStaffs_staffId",
                table: "Transactions",
                column: "staffId",
                principalTable: "LibraryStaffs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Books_bookId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Branches_BranchId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_LibraryMembers_memberId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_LibraryStaffs_staffId",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.RenameTable(
                name: "Transactions",
                newName: "Transaction");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_staffId",
                table: "Transaction",
                newName: "IX_Transaction_staffId");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_memberId",
                table: "Transaction",
                newName: "IX_Transaction_memberId");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_BranchId",
                table: "Transaction",
                newName: "IX_Transaction_BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_bookId",
                table: "Transaction",
                newName: "IX_Transaction_bookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Books_bookId",
                table: "Transaction",
                column: "bookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Branches_BranchId",
                table: "Transaction",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_LibraryMembers_memberId",
                table: "Transaction",
                column: "memberId",
                principalTable: "LibraryMembers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_LibraryStaffs_staffId",
                table: "Transaction",
                column: "staffId",
                principalTable: "LibraryStaffs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
