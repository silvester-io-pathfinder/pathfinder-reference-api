using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReprepareSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("ed49ff75-edb7-4abc-9016-8e9b8885fd85");

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
            yield return new TextBlock { Id = Guid.Parse("fe4d8150-f253-43c4-88c5-a486804bea13"), Type = TextBlockType.Text, Text = "You’ve discovered how to reuse some of your spell slots over and over. You can spend 10 minutes to prepare a spell that you already cast today, regaining access to that spell slot. The spell must be of 4th level or lower and one that does not have a duration. You can reprepare a spell in this way even if you’ve already reprepared that spell previously in the same day." };
            yield return new TextBlock { Id = Guid.Parse("958f5d8b-e376-4bfd-ae38-bb4985508fb0"), Type = TextBlockType.Text, Text = "If you have the spell substitution arcane thesis, you can instead prepare a different spell in an expended slot, as long as the new spell doesn’t have a duration. Once you’ve reprepared a spell in that slot even once, you can use your arcane thesis to substitute only spells without durations into that spell slot." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("220d679c-de88-4c7b-9452-b62582ee83e7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
