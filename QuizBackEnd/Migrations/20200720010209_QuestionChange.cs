using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizBackEnd.Migrations
{
    public partial class QuestionChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverImageUrl",
                table: "Quiz");

            migrationBuilder.RenameColumn(
                name: "InCorrectAnswer3",
                table: "Questions",
                newName: "IncorrectAnswer3");

            migrationBuilder.RenameColumn(
                name: "InCorrectAnswer2",
                table: "Questions",
                newName: "IncorrectAnswer2");

            migrationBuilder.RenameColumn(
                name: "InCorrectAnswer1",
                table: "Questions",
                newName: "IncorrectAnswer1");

            migrationBuilder.AlterColumn<string>(
                name: "Question",
                table: "Questions",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IncorrectAnswer3",
                table: "Questions",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IncorrectAnswer2",
                table: "Questions",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IncorrectAnswer1",
                table: "Questions",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CorrectAnswer",
                table: "Questions",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IncorrectAnswer3",
                table: "Questions",
                newName: "InCorrectAnswer3");

            migrationBuilder.RenameColumn(
                name: "IncorrectAnswer2",
                table: "Questions",
                newName: "InCorrectAnswer2");

            migrationBuilder.RenameColumn(
                name: "IncorrectAnswer1",
                table: "Questions",
                newName: "InCorrectAnswer1");

            migrationBuilder.AddColumn<string>(
                name: "CoverImageUrl",
                table: "Quiz",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Question",
                table: "Questions",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "InCorrectAnswer3",
                table: "Questions",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "InCorrectAnswer2",
                table: "Questions",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "InCorrectAnswer1",
                table: "Questions",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CorrectAnswer",
                table: "Questions",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
