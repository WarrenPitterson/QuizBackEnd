using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizBackEnd.Migrations
{
    public partial class QuestionDM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Question",
                table: "Questions",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "IncorrectAnswer3",
                table: "Questions",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "IncorrectAnswer2",
                table: "Questions",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "IncorrectAnswer1",
                table: "Questions",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CorrectAnswer",
                table: "Questions",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
