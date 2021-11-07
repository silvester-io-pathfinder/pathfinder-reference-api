using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScalpelsPoint : Template
    {
        public static readonly Guid ID = Guid.Parse("1d37d75f-534a-4320-8ca4-3f25c06a31b4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scalpel's Point",
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
            yield return new TextBlock { Id = Guid.Parse("0284f7c5-355a-403f-a742-8708a36a26d1"), Type = TextBlockType.Text, Text = "Your stratagems benefit from your precise knowledge of anatomy. When you critically hit with an attack on which you substituted your attack roll due to (action: Devising a Stratagem | Devise a Stratagem), if your attack dealt piercing or slashing damage, you also deal 1d6 persistent bleed damage to your target." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMethodology(Guid.Parse("6aecca27-3b53-415b-8b97-9488ce90de1e"), Methodologies.Instances.ForensicMedicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e7d30cfb-9be0-4708-822c-bdabb3cc6ecd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
