# Prototipos del proyecto Polnice

https://www.figma.com/file/VG0qcGDGiEVhh8ZHGCSNph/INICIO?node-id=0%3A1

# Pasos usados para esta APP

git clone https://github.com/DianaTorresGamarra/appPolnice

cd appPolnice

dotnet new mvc --auth Individual

vscode>terminal

dotnet tool install --global dotnet-aspnet-codegenerator --version 6.0.2

add .gitignore

https://dashboard.heroku.com/apps/apppolnice/resources

add postgress

dotnet aspnet-codegenerator identity -dc appPolnice.Data.ApplicationDbContext --files "Account.Register;Account.Login"

editas los nombres y el html

borrar la carpeta migrations

dotnet ef migrations add InitialMigration --context appPolnice.Data.ApplicationDbContext -o "C:\code\2022\appPolnice\Data\Migrations"

dotnet ef database update

# appPolnice

Aplicación web de venta de ropa para hombres
