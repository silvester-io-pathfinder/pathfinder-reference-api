using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FamiliarConduit : Template
    {
        public static readonly Guid ID = Guid.Parse("b8fbba38-95d1-48ce-92dc-f9e18a6f7ad1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Familiar Conduit",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3ae2cf43-63f2-45da-a3a3-00af84465e42"), Type = TextBlockType.Text, Text = "Under your tutelage, your familiar has grown attuned to the hidden currents of the world and can serve as a conduit for your magic. If the next action you use is to (activity: Cast a Spell) that has a range, the spell uses the familiar as its origin point." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("361110fe-a597-4d8f-9933-e914bf19d4c5"), Feats.Instances.FamiliarMasterDedication.ID);
            builder.HaveAnyMagicTradition(Guid.Parse("a3d7cb68-8485-44a4-b586-fe418b83a314"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56cdc6cb-794b-455a-9fcb-e7bbc50f6796"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
