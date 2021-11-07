using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Fear : Template
    {
        public static readonly Guid ID = Guid.Parse("81fdf920-ee4d-49f1-aab0-f716f21cb18e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fear",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ee0cd17c-ea93-4362-958f-85f2d85a55c7"), Type = TextBlockType.Text, Text = "You let your fear fuel you, rather than consume you, but it burns your endurance." };
            yield return new TextBlock { Id = Guid.Parse("087359b4-0364-4c5c-bbb7-b0b3ec43ccf3"), Type = TextBlockType.Text, Text = "~ Catharsis Trigger: An enemy makes you frightened." };
            yield return new TextBlock { Id = Guid.Parse("70e01c31-ef5c-427d-bae9-9c8b5a3fe5dc"), Type = TextBlockType.Text, Text = "~ Catharsis Activation: Increase your frightened value by 1, to a maximum of frightened 4." };
            yield return new TextBlock { Id = Guid.Parse("9e156e81-d3cc-4c1c-9646-a9a48019f524"), Type = TextBlockType.Text, Text = "~ Emotional Fervor: You don’t take the status penalty from the frightened condition to your spell DCs or spell attack bonus. Instead, you gain a status bonus to spell attack rolls equal to the penalty you would’ve taken, and your foes take the same status penalty to their saving throws against your spells. Any other statistic takes the status penalty as normal. Spell: (spell: fear)" };
            yield return new TextBlock { Id = Guid.Parse("2823e2ca-7fcc-4c95-97c6-52a19f3f0cbe"), Type = TextBlockType.Text, Text = "~ Emotional Fallout: You are fleeing for 2 rounds, running from the source of the frightened condition that triggered your (feat: Catharsis). If that source is no longer present, you instead flee from the position where you were at the start of your emotional fallout." };
            yield return new TextBlock { Id = Guid.Parse("297660c9-cfb0-46b9-af99-7cab55813607"), Type = TextBlockType.Text, Text = "~ Focus Spell: (spell: waking nightmare)" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae470f2b-7a02-46bb-b872-990c0231be6b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
