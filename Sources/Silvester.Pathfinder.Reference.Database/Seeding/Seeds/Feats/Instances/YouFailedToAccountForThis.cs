using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class YouFailedToAccountForThis : Template
    {
        public static readonly Guid ID = Guid.Parse("8c07ae21-ebd7-462f-9ecc-e75fe7208f15");

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
            yield return new TextBlock { Id = Guid.Parse("80c386a4-1b80-4ce9-aaa2-b4c44c0a9bfd"), Type = TextBlockType.Text, Text = "When your foes try to attack you, you always seem to have some outlandish invention you can pull out at the last second to protect you from whatever attack they throw at you. Describe a device you’re attempting to use to protect yourself from the foe’s attack—for instance, when attacked by a shocker lizard’s shock (action: Strike), you might pull out a specially grounded lightning rod from that time you tried to power an invention by harnessing a thunderstorm! Using an invention to defend in this way means that the attack roll for the triggering attack targets your Crafting DC instead of your AC." };
            yield return new TextBlock { Id = Guid.Parse("0a6799be-faa5-4ef4-98a1-881160004663"), Type = TextBlockType.Text, Text = "Since you’re using your Crafting DC instead of your AC, any penalties to your AC don’t apply, but this doesn’t remove any conditions or other effects that are causing you such penalties. For instance, if you were flat-footed and used an invention to defend against a sneak attack, you’d still take the extra precision damage if you were hit, even though the –2 penalty to AC from being flat-footed wouldn’t apply to your Crafting DC." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("491aa7d4-19f5-42f9-a512-0aae8b54cf79"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
