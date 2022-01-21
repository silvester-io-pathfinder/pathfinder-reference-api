using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AccidentalShot : Template
    {
        public static readonly Guid ID = Guid.Parse("8e4e1fd6-f6a9-4f73-89f2-6c89a55d6913");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Accidental Shot",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9888953b-3e55-4dc1-8ea8-6b4f99c5ff49"), Type = TextBlockType.Text, Text = $"You make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with a ranged weapon, rolling the attack and damage twice and using the better results for each. The attack ignores circumstance penalties to the attack roll and any flat check required due to the target being concealed or hidden." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f8bea04a-d986-4a90-abf0-910c8dd56825"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
