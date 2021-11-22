using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class YouFailedToAccountForThis : Template
    {
        public static readonly Guid ID = Guid.Parse("b5b94293-9d37-46f3-aac9-6648b16cbdaf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "You Failed To Account For... This!",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature you can see targets you with an attack against your AC.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ab516d0f-900a-42ba-b9e0-ab04e428cdf4"), Type = TextBlockType.Text, Text = "When your foes try to attack you, you always seem to have some outlandish invention you can pull out at the last second to protect you from whatever attack they throw at you. Describe a device you're attempting to use to protect yourself from the foe's attack—for instance, when attacked by a shocker lizard's shock (action: Strike), you might pull out a specially grounded lightning rod from that time you tried to power an invention by harnessing a thunderstorm! Using an invention to defend in this way means that the attack roll for the triggering attack targets your Crafting DC instead of your AC." };
            yield return new TextBlock { Id = Guid.Parse("45d2be42-cb5a-42e7-a435-d62a5d112ec4"), Type = TextBlockType.Text, Text = "Since you're using your Crafting DC instead of your AC, any penalties to your AC don't apply, but this doesn't remove any conditions or other effects that are causing you such penalties. For instance, if you were flat-footed and used an invention to defend against a sneak attack, you'd still take the extra precision damage if you were hit, even though the –2 penalty to AC from being flat-footed wouldn't apply to your Crafting DC." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("36ba2094-f0ac-40a0-8406-32261c347572"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
