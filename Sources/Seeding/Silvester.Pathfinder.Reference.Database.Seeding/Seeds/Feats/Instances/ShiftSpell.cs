using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShiftSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("5faecbf6-1273-4fd8-b9c0-4a8405e38d4f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shift Spell",
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
            yield return new TextBlock { Id = Guid.Parse("b4cdc138-3ea7-49bd-9628-6cbde6909f33"), Type = TextBlockType.Text, Text = "~ Access: member of the Magaambya" };
            yield return new TextBlock { Id = Guid.Parse("1f02ed99-ab14-4037-af75-b1b5d4f51b89"), Type = TextBlockType.Text, Text = "You move the spell&#39;s area to a new location within 120 feet. The spell&#39;s remaining duration is reduced by half. The spell no longer affects its previous area." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc2fc966-6530-4c06-a66a-a8531035a577"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
