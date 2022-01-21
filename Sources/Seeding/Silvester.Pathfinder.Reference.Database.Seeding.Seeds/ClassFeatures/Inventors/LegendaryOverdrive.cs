using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Inventors
{
    public class LegendaryOverdrive : Template
    {
        public static readonly Guid ID = Guid.Parse("4177c6fd-1546-4d7b-b073-5632090da12a");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 15,
                Name = "Legendary Overdrive", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ea7c64f4-ea17-4cb2-a6dc-2f244ce97b33"), Type = TextBlockType.Text, Text = "Your peerless inventing and Crafting ability has supercharged your Overdrives. You become legendary in Crafting, and on a successful Overdrive, you increase the additional damage by a total of 3, replacing the increase from master overdrive." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("75d73117-796e-4fc3-a42d-cfef6ec1032c"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Crafting.ID);
            //TODO: Add Overdrive modification effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aec3c3cf-5458-4167-8b3d-caa0d95d9368"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 2
            };
        }
    }
}
