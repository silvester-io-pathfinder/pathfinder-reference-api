using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReprepareSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("5b778dd5-643e-416d-9fe2-0c9d74d2b60f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reprepare Spell",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d7c9638a-bbaf-4cdf-abf0-4ee13df17d9f"), Type = TextBlockType.Text, Text = "You’ve discovered how to reuse some of your spell slots over and over. You can spend 10 minutes to prepare a spell that you already cast today, regaining access to that spell slot. The spell must be of 4th level or lower and one that does not have a duration. You can reprepare a spell in this way even if you’ve already reprepared that spell previously in the same day." };
            yield return new TextBlock { Id = Guid.Parse("149a10aa-1fc9-400f-9cdb-5c344bade0cc"), Type = TextBlockType.Text, Text = "If you have the spell substitution arcane thesis, you can instead prepare a different spell in an expended slot, as long as the new spell doesn’t have a duration. Once you’ve reprepared a spell in that slot even once, you can use your arcane thesis to substitute only spells without durations into that spell slot." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("72b932c3-3e49-4ccb-8be0-f5a6b37c3049"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
