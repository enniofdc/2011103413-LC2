namespace _2011103413_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Model : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Asientoes",
                c => new
                    {
                        AsientoId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                        Cinturon_CinturonId = c.Int(),
                    })
                .PrimaryKey(t => t.AsientoId)
                .ForeignKey("dbo.Cinturons", t => t.Cinturon_CinturonId)
                .Index(t => t.Cinturon_CinturonId);
            
            CreateTable(
                "dbo.Cinturons",
                c => new
                    {
                        CinturonId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                        Metraje = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CinturonId);
            
            CreateTable(
                "dbo.Automovils",
                c => new
                    {
                        AutomovilId = c.Int(nullable: false, identity: true),
                        TipoAuto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AutomovilId);
            
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        BusId = c.Int(nullable: false, identity: true),
                        TipoBus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BusId);
            
            CreateTable(
                "dbo.Carroes",
                c => new
                    {
                        CarroId = c.Int(nullable: false, identity: true),
                        NumSerieMotor = c.String(),
                        NumSerieChasis = c.String(),
                        TipoCarro = c.Int(nullable: false),
                        Asiento_AsientoId = c.Int(),
                        Automovil_AutomovilId = c.Int(),
                        Bus_BusId = c.Int(),
                        Llanta_LlantaId = c.Int(),
                        Parabrisas_ParabrisasId = c.Int(),
                        Propietario_PropietarioId = c.Int(),
                        Volante_VolanteId = c.Int(),
                    })
                .PrimaryKey(t => t.CarroId)
                .ForeignKey("dbo.Asientoes", t => t.Asiento_AsientoId)
                .ForeignKey("dbo.Automovils", t => t.Automovil_AutomovilId)
                .ForeignKey("dbo.Buses", t => t.Bus_BusId)
                .ForeignKey("dbo.Llantas", t => t.Llanta_LlantaId)
                .ForeignKey("dbo.Parabrisas", t => t.Parabrisas_ParabrisasId)
                .ForeignKey("dbo.Propietarios", t => t.Propietario_PropietarioId)
                .ForeignKey("dbo.Volantes", t => t.Volante_VolanteId)
                .Index(t => t.Asiento_AsientoId)
                .Index(t => t.Automovil_AutomovilId)
                .Index(t => t.Bus_BusId)
                .Index(t => t.Llanta_LlantaId)
                .Index(t => t.Parabrisas_ParabrisasId)
                .Index(t => t.Propietario_PropietarioId)
                .Index(t => t.Volante_VolanteId);
            
            CreateTable(
                "dbo.Llantas",
                c => new
                    {
                        LlantaId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                    })
                .PrimaryKey(t => t.LlantaId);
            
            CreateTable(
                "dbo.Parabrisas",
                c => new
                    {
                        ParabrisasId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                    })
                .PrimaryKey(t => t.ParabrisasId);
            
            CreateTable(
                "dbo.Propietarios",
                c => new
                    {
                        PropietarioId = c.Int(nullable: false, identity: true),
                        Dni = c.String(),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        LicenciaConducir = c.String(),
                    })
                .PrimaryKey(t => t.PropietarioId);
            
            CreateTable(
                "dbo.Volantes",
                c => new
                    {
                        VolanteId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                    })
                .PrimaryKey(t => t.VolanteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carroes", "Volante_VolanteId", "dbo.Volantes");
            DropForeignKey("dbo.Carroes", "Propietario_PropietarioId", "dbo.Propietarios");
            DropForeignKey("dbo.Carroes", "Parabrisas_ParabrisasId", "dbo.Parabrisas");
            DropForeignKey("dbo.Carroes", "Llanta_LlantaId", "dbo.Llantas");
            DropForeignKey("dbo.Carroes", "Bus_BusId", "dbo.Buses");
            DropForeignKey("dbo.Carroes", "Automovil_AutomovilId", "dbo.Automovils");
            DropForeignKey("dbo.Carroes", "Asiento_AsientoId", "dbo.Asientoes");
            DropForeignKey("dbo.Asientoes", "Cinturon_CinturonId", "dbo.Cinturons");
            DropIndex("dbo.Carroes", new[] { "Volante_VolanteId" });
            DropIndex("dbo.Carroes", new[] { "Propietario_PropietarioId" });
            DropIndex("dbo.Carroes", new[] { "Parabrisas_ParabrisasId" });
            DropIndex("dbo.Carroes", new[] { "Llanta_LlantaId" });
            DropIndex("dbo.Carroes", new[] { "Bus_BusId" });
            DropIndex("dbo.Carroes", new[] { "Automovil_AutomovilId" });
            DropIndex("dbo.Carroes", new[] { "Asiento_AsientoId" });
            DropIndex("dbo.Asientoes", new[] { "Cinturon_CinturonId" });
            DropTable("dbo.Volantes");
            DropTable("dbo.Propietarios");
            DropTable("dbo.Parabrisas");
            DropTable("dbo.Llantas");
            DropTable("dbo.Carroes");
            DropTable("dbo.Buses");
            DropTable("dbo.Automovils");
            DropTable("dbo.Cinturons");
            DropTable("dbo.Asientoes");
        }
    }
}
