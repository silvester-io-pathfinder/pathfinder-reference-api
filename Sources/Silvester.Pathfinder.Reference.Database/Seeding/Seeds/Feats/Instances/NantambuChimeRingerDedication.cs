using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NantambuChimeRingerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("fa7bc1c1-8e3a-4b38-82f9-830fd1d04ce3");

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
            yield return new TextBlock { Id = Guid.Parse("b3609dd9-8c45-4860-93cf-58a4bc69c081"), Type = TextBlockType.Text, Text = "You&#39;ve studied the basics of harmony and resonance in magic, exemplified by the ringing of chimes. You gain a single tradition arcane or occult cantrip of your choice, heightened to a spell level equal to half your level, rounded up. If you weren&#39;t already, you become trained in that tradition&#39;s spell DCs and spell attack rolls, with Intelligence as your spellcasting ability if you choose arcane or Charisma as your spellcasting ability if you choose occult. Regardless of your choice, you also either become trained in Arcana or Occultism, or an expert in one of these skills if you are already trained in both." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("1e118816-2e60-4cab-a7ce-77de7282e716"), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("9fef9cfc-90f2-488b-a201-88c53e5966de"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("68dc279d-4844-47ec-98ce-c7042325eb57"),
                SourceId = Sources.Instances.StrengthOfThousands.ID,
                Page = -1
            };
        }
    }
}
