using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VigorousInspiration : Template
    {
        public static readonly Guid ID = Guid.Parse("c0ca583d-1c40-4589-a808-610c5b50399e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vigorous Inspiration",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3d3fb396-fb80-48de-954d-5bed495908f7"), Type = TextBlockType.Text, Text = "You instill magical vigor in your allies when you inspire them to attack. If your next action is to cast the (spell: inspire courage) composition cantrip, you and all affected allies gain temporary Hit Points equal to 3 + your Charisma modifier that last for 1 minute." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2404326-075d-4590-8555-32a2034b9c91"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
