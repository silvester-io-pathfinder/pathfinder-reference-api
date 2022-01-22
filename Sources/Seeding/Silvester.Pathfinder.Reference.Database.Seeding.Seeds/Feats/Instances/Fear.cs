using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Fear : Template
    {
        public static readonly Guid ID = Guid.Parse("4f3a3d0d-5622-4bac-b202-eefc1891136e");

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
            yield return new TextBlock { Id = Guid.Parse("f38e965c-fd0f-4592-a620-ebc647f94617"), Type = TextBlockType.Text, Text = $"You let your fear fuel you, rather than consume you, but it burns your endurance." };
            yield return new TextBlock { Id = Guid.Parse("bbd379ab-a322-4d26-866f-8d9045db5119"), Type = TextBlockType.Text, Text = $"~ Catharsis Trigger: An enemy makes you frightened." };
            yield return new TextBlock { Id = Guid.Parse("68df77f7-44e2-4844-913c-fb3facd734eb"), Type = TextBlockType.Text, Text = $"~ Catharsis Activation: Increase your frightened value by 1, to a maximum of frightened 4." };
            yield return new TextBlock { Id = Guid.Parse("509da6f2-1262-4af4-8735-182f52b044f7"), Type = TextBlockType.Text, Text = $"~ Emotional Fervor: You don't take the status penalty from the frightened condition to your spell DCs or spell attack bonus. Instead, you gain a status bonus to spell attack rolls equal to the penalty you would've taken, and your foes take the same status penalty to their saving throws against your spells. Any other statistic takes the status penalty as normal. Spell: {ToMarkdownLink<Models.Entities.Spell>("fear", Spells.Instances.Fear.ID)}" };
            yield return new TextBlock { Id = Guid.Parse("23e584cc-50c9-44ae-9615-81e882f3a509"), Type = TextBlockType.Text, Text = $"~ Emotional Fallout: You are fleeing for 2 rounds, running from the source of the frightened condition that triggered your {ToMarkdownLink<Models.Entities.Feat>("Catharsis", Feats.Instances.Catharsis.ID)}. If that source is no longer present, you instead flee from the position where you were at the start of your emotional fallout." };
            yield return new TextBlock { Id = Guid.Parse("24255bf2-b099-450e-bc53-5dd4b893653c"), Type = TextBlockType.Text, Text = $"~ Focus Spell: {ToMarkdownLink<Models.Entities.Spell>("waking nightmare", Spells.Instances.WakingNightmare.ID)}" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c5466d8d-e1a4-4579-9e77-15fcd0f5fec0"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
