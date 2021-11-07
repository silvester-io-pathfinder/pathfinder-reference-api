using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LiberatingStep : Template
    {
        public static readonly Guid ID = Guid.Parse("8d87663e-0345-4b99-8d48-4c2a1d7593fd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Liberating Step",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An enemy damages, Grabs, or Grapples your ally, and both are within 15 feet of you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e4207e9b-8c74-47ef-a7f9-f1500801990b"), Type = TextBlockType.Text, Text = "You free an ally from restraint. If the trigger was an ally taking damage, the ally gains resistance to all damage against the triggering damage equal to 2 + your level. The ally can attempt to break free of effects grabbing, restraining, immobilizing, or paralyzing them. They either attempt a new save against one such effect that allows a save, or attempt to (action: Escape) from one effect as a free action. If they can move, the ally can (action: Step) as a free action, even if they didn’t need to escape." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1bc83fc3-a320-43bf-b005-0d13ca74202a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
