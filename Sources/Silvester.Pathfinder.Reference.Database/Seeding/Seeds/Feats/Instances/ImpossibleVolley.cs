using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImpossibleVolley : Template
    {
        public static readonly Guid ID = Guid.Parse("c739b44e-1411-4d84-bde9-0e21fc5e6202");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Impossible Volley",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a7db9271-5695-4cb4-8d63-ce7084645e8f"), Type = TextBlockType.Text, Text = "You fire a volley at all foes in an area. Make one (action: Strike) with a -2 penalty against each enemy within a 10-foot-radius burst centered at or beyond your weapon’s volley range. Roll the damage only once for all targets." };
            yield return new TextBlock { Id = Guid.Parse("d431b0d7-606a-4042-af97-a5f6ac43a599"), Type = TextBlockType.Text, Text = "Each attack counts toward your multiple attack penalty, but do not increase your penalty until you have made all your attacks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("136f228e-6e97-45c6-8746-ecedf9954b75"), Feats.Instances.EldritchArcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("86686ea9-34f2-4145-a475-943dc46d6af5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
