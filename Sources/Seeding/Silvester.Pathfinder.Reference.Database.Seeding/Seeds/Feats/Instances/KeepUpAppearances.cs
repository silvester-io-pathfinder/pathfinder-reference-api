using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KeepUpAppearances : Template
    {
        public static readonly Guid ID = Guid.Parse("86498c8b-17a3-4730-bb66-1af021ed51f5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Keep Up Appearances",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are affected by an emotion effect.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("42171f05-1468-41fe-87a8-eb5845ef17f8"), Type = TextBlockType.Text, Text = "~ Access: Taldan nationality" };
            yield return new TextBlock { Id = Guid.Parse("4f97b4f9-6599-47cf-9ba0-e0a7c8079b01"), Type = TextBlockType.Text, Text = "Taldan pride means you never show weakness. Roll a Deception check and compare the result to any observing creatures’ Perception DCs. On a success, that creature believes you were unaffected by the (trait: emotion) effect. A creature tricked in this manner can’t benefit from the (trait: emotion) effect and can’t use abilities that require you to be under this (trait: emotion) effect; for example, if you successfully use this ability to trick a will-o’-wisp (Pathfinder Bestiary 333) into believing you aren’t under a fear effect, it can’t use its Feed on Fear ability on you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c1e7e498-9811-4b00-9ab9-a8c3bc40aed3"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
