using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NantambuChimeRingerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("2a687d05-ce41-43b9-8c46-203a4c3f2cfd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nantambu Chime-Ringer Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the Nantambu Chime-Ringer archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("86191140-20c5-41f9-a35a-ff2267161058"), Type = TextBlockType.Text, Text = $"You've studied the basics of harmony and resonance in magic, exemplified by the ringing of chimes. You gain a single tradition arcane or occult cantrip of your choice, heightened to a spell level equal to half your level, rounded up. If you weren't already, you become trained in that tradition's spell DCs and spell attack rolls, with Intelligence as your spellcasting ability if you choose arcane or Charisma as your spellcasting ability if you choose occult. Regardless of your choice, you also either become trained in Arcana or Occultism, or an expert in one of these skills if you are already trained in both." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("bf4271bc-5eaf-48d4-9f68-abc9f2bc1ee3"), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("0d0ac659-5ebb-486d-bcd0-0130c58bcf4f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("24eb7771-7b30-4390-b2eb-5dbced32fc06"),
                SourceId = Sources.Instances.StrengthOfThousands.ID,
                Page = -1
            };
        }
    }
}
