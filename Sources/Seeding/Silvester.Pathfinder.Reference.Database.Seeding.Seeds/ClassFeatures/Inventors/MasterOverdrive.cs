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
    public class MasterOverdrive : Template
    {
        public static readonly Guid ID = Guid.Parse("5e58a80c-d140-4cd2-838a-1be14cac877c");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 7,
                Name = "Master Overdrive", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9c36835e-9ac5-4285-9f41-8b44a1b4f313"), Type = TextBlockType.Text, Text = "Your mastery of invention and crafting enhances your Overdrive even further. You become a master in Crafting, and on a successful Overdrive, you increase the additional damage by a total of 2, replacing the increase from expert overdrive." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("33652a6f-70ee-490d-b29e-bc4958a4cef0"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
            //TODO: Add the increased damage effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("459b8937-7218-4c10-9246-8cb3d546b71d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 22
            };
        }
    }
}
