using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TwoWeaponFlurry : Template
    {
        public static readonly Guid ID = Guid.Parse("2a5fbb28-0789-4480-b17e-0391da7119b6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Two-Weapon Flurry",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("638503b1-ae07-45ec-89c6-237f4aad2e42"), Type = TextBlockType.Text, Text = "You lash out with both your weapons in a sudden frenzy. (action: Strike) twice, once with each weapon." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f6f67195-f2b2-426d-907b-1df0f91f028b"), Feats.Instances.DualWeaponDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bfdc694a-9696-447e-8358-31bc0a4463a3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
