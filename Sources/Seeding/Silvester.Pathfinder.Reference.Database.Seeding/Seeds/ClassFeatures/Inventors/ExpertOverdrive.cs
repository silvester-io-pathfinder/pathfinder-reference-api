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
    public class ExpertOverdrive : Template
    {
        public static readonly Guid ID = Guid.Parse("9354fa47-c14d-46e2-9b73-5b3a020aa4fa");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "Expert Overdrive", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("fcc1cff2-6fd4-4041-aa02-b0dd7d779a6d"), Type = TextBlockType.Text, Text = "You've increased your skill in crafting, and you can put your devices into a more powerful state of overdrive. You become an expert in Crafting, and on a successful use of Overdrive, you increase the additional damage by 1." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("7f830bf4-5386-44e2-82b1-343aeacd0486"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
            //TODO: Add +1 damage to Overdrive effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4248c7fa-fa2a-416c-8294-0029e7675b75"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 20
            };
        }
    }
}
