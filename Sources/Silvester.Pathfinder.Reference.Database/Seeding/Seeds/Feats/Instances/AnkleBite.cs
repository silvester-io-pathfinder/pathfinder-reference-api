using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnkleBite : Template
    {
        public static readonly Guid ID = Guid.Parse("8bc465a6-d24a-40be-a6fc-fcabc15a8259");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ankle Bite",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A foe gives you the grabbed or restrained condition using a part of its body.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5b007ba2-25d9-4eeb-8a6e-42967a53b4cf"), Type = TextBlockType.Text, Text = "Whenever someone grabs onto you, you instinctively bite down hard. Sometimes that makes them let go, and sometimes it just makes them angrier, but either way, it’s both satisfying and tasty. Make a jaws (action: Strike) against the triggering foe. On a critical hit, you are no longer grabbed. This (action: Strike) doesn’t count toward your multiple attack penalty, and your multiple attack penalty doesn’t apply to this (action: Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("d1078d0e-7b73-40bb-92d2-efd3a6dea730"), or => 
            {
                or.HaveSpecificHeritage(Guid.Parse("42aef528-027b-4047-b68c-4c23443480a2"), Heritages.Instances.FangSharpenerGoblin.ID);
                or.HaveSpecificHeritage(Guid.Parse("01923cdd-27dc-49bf-b227-45f39bad073d"), Heritages.Instances.RazortoothGoblin.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b8b0d8da-ac5a-4fe6-96f5-1cdc58834c4b"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
