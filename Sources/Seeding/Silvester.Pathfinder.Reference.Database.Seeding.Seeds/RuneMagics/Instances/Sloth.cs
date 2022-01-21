using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.RuneMagics.Instances
{
    public class Sloth : Template
    {
        public static readonly Guid ID = Guid.Parse("9949d79e-e319-44f1-a532-7b2110be968c");
        
        protected override RuneMagic GetRuneMagic()
        {
            return new RuneMagic
            {
                Id = ID, 
                Name = "Sloth",
                Description = "Runelords of conjuration use their magic to create what they need as they need it, and call forth servants to do their bidding.",
                InitialRuneSpellId = Spells.Instances.EfficientApport.ID,
                AdvancedRuneSpellId = Spells.Instances.SwampOfSloth.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        protected override IEnumerable<RuneMagicSchoolBinding> GetProhibitedMagicSchools()
        {
            yield return new RuneMagicSchoolBinding { Id = Guid.Parse("b5ce9f91-df59-4b40-9147-a1b5e2284ea6"), MagicSchoolId = MagicSchools.Instances.Evocation.ID };
            yield return new RuneMagicSchoolBinding { Id = Guid.Parse("3b4aa0ec-c247-457c-9c8b-e03241059c0a"), MagicSchoolId = MagicSchools.Instances.Illusion.ID };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("583b8bfb-5552-4bf1-a76c-88b6deef1e46"), Spells.Instances.EfficientApport.ID);
            
            builder
                .GainSpecificSpell(Guid.Parse("2647a1c8-19cf-44c5-88e3-c49b105f4352"), Spells.Instances.SwampOfSloth.ID)
                .AddPrerequisites(Guid.Parse("0e912784-a2b2-4b19-bf13-6d3e1fca4a35"), prerequisites => 
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("266da425-7bfc-438b-8447-5e34af619bed"), Comparator.GreaterThanOrEqualTo, requiredLevel: 8);
                });

            builder.ProhibitSpecificMagicSchool(Guid.Parse("2a9504ae-7a22-4a90-bcc6-632210e64c53"), MagicSchools.Instances.Evocation.ID);
            builder.ProhibitSpecificMagicSchool(Guid.Parse("9ef3838e-7792-48e5-bc3a-2c454bfc52f0"), MagicSchools.Instances.Illusion.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c6ab8c2e-14f2-4efd-b669-5e4c3a841319"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 239
            };
        }
    }
}
