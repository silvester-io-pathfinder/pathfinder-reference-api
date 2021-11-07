using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OverwhelmingBlow : Template
    {
        public static readonly Guid ID = Guid.Parse("b5dbc691-4703-4bcf-8886-ee84184fde77");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Overwhelming Blow",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f7874c2f-59f0-4233-a640-75860bfe9a88"), Type = TextBlockType.Text, Text = "You throw your weight into a powerful attack that leaves you vulnerable. Make a melee (action: Strike). This counts as three attacks when calculating your multiple attack penalty. If this (action: Strike) hits, you get a critical hit. If you roll a critical hit, your attack also gains the deadly d12 trait. Whether or not you hit, you become stunned 1 and are flat-footed until the start of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("66629f51-3e1d-4e27-9202-01902de8411b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
