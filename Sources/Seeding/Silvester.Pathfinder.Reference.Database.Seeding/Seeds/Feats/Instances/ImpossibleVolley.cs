using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImpossibleVolley : Template
    {
        public static readonly Guid ID = Guid.Parse("ed3d0ce2-21f0-4e91-884d-3b7ade0b5f8d");

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
            yield return new TextBlock { Id = Guid.Parse("60d4dac3-2014-4ca7-8690-980458397a9d"), Type = TextBlockType.Text, Text = "You fire a volley at all foes in an area. Make one (action: Strike) with a -2 penalty against each enemy within a 10-foot-radius burst centered at or beyond your weapon's volley range. Roll the damage only once for all targets." };
            yield return new TextBlock { Id = Guid.Parse("7852894e-e2da-47b9-add5-1d0d7dc4a7b8"), Type = TextBlockType.Text, Text = "Each attack counts toward your multiple attack penalty, but do not increase your penalty until you have made all your attacks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b1b51270-4980-4fa2-8349-a7275a184d36"), Feats.Instances.EldritchArcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c481b71-5c04-4105-ba02-5672873eff1d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
