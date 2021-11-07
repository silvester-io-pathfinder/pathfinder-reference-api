using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EldritchResearcherDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("ee073710-2b9f-42ed-82ed-5c18d3bad81d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eldritch Researcher Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained two other feats from the Eldritch Researcher archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("781b67c2-ca8f-4606-86f3-c5cb318c87c1"), Type = TextBlockType.Text, Text = "You gain the ability to cast a single arcane or occult cantrip of your choice (which is heightened to a spell level equal to half your level rounded up). If you weren&#39;t already, you become trained in that tradition&#39;s spell DCs and spell attack rolls with Intelligence as your spellcasting ability." };
            yield return new TextBlock { Id = Guid.Parse("efeffce1-aa8c-4dd0-8ef9-b5d87fb55ae7"), Type = TextBlockType.Text, Text = "Regardless of whether you choose an arcane or occult cantrip, you also become an expert in your choice of either Arcana or Occultism. You also gain a +1 circumstance bonus to checks you attempt with the chosen skill when (action: Investigating | Investigate) or (action: Identifying Magic | Identify Magic)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("9d13e3b7-a0c7-4cf5-88f4-ce73faad2e81"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("17417b11-c9ef-45c8-b14c-4094de29d2d0"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("59700c42-2a6f-4464-b8b8-5a437627c7fa"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
