using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CallUponTheBrightness : Template
    {
        public static readonly Guid ID = Guid.Parse("fdd0e739-ad0f-433d-b5c3-756e990f6d22");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Call Upon the Brightness",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You attempt an attack roll, skill check, or saving throw while performing the course of action from your augury, but you haven't rolled yet.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5dc58060-7f5f-48a2-abb0-d8116f14afea"), Type = TextBlockType.Text, Text = "You gain a +1 status bonus to the triggering check, or a +2 status bonus if the result of the augury was “woe” and you proceeded anyway." };
            yield return new TextBlock { Id = Guid.Parse("c201db3d-f5f0-426b-8228-7bf9af412db7"), Type = TextBlockType.Text, Text = "__You can only use this reaction for the next 30 minutes after casting (spell: augury) from the (feat: Brightness Seeker) feat.__" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2a2c4214-35c0-4e95-84eb-1fd0e070311f"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
