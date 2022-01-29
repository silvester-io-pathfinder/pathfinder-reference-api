using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Spellstriker : Template
    {
        public static readonly Guid ID = Guid.Parse("99faf6cf-4a4d-40f0-9390-0810c81dc314");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spellstriker",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("59b2dfeb-732f-43bb-ac35-8e98b49222b5"), Type = TextBlockType.Text, Text = $"You gain the magus's {ToMarkdownLink<Models.Entities.Feat>("Spellstrike", Feats.Instances.Spellstrike.ID)} activity. You can recharge it only as an activity that takes 1 minute. This restriction applies even if you gain another ability that recharges {ToMarkdownLink<Models.Entities.Feat>("Spellstrike", Feats.Instances.Spellstrike.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3535cab0-6d41-4b3f-a643-f58b84c77f6d"), Feats.Instances.MagusDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf7219dc-b29d-4045-9b8e-12967d286f9a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
