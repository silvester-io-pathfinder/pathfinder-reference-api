using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SteamSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("fd2c0869-563e-4c83-a15d-cfca8e92cb7d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Steam Spell",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3e538380-4dee-4b9f-866a-11de639b3aa9"), Type = TextBlockType.Text, Text = "You transform your fire spells into steam, making them more effective underwater. If your next action is to (action: Cast a Spell) with the (trait: fire) trait, you can cast it underwater. When you do so, it takes the form of scalding steam. Underwater creatures do not gain the normal fire resistance for being underwater against this spell, but they don’t light things on fire or cause persistent fire damage, nor do they add other effects that would apply to fire but not steam (at the GM’s discretion)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a9639a45-696c-480a-a7f4-9fa2db4c4c71"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
