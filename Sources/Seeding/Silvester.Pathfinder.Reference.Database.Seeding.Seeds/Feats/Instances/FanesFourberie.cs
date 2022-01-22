using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FanesFourberie : Template
    {
        public static readonly Guid ID = Guid.Parse("5a4cfac1-dd76-484b-b94d-d6d6725cedad");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fane's Fourberie",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("23e4a40f-e30d-4f5b-b215-1b76ce720ae8"), Type = TextBlockType.Text, Text = $"~ Access: Member of the Pathfinder Society." };
            yield return new TextBlock { Id = Guid.Parse("622679e2-140e-4b5a-a124-f2f3cdd9edf1"), Type = TextBlockType.Text, Text = $"Stella Fane has perfected a technique for using {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("playing cards", Items.AdventuringGears.Instances.PlayingCards.ID)} as weapons that's one part sleight of hand and one part magic. When you enter this stance, choose whether to treat {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("playing cards", Items.AdventuringGears.Instances.PlayingCards.ID)} in your possession as {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("daggers", Items.MeleeWeapons.Instances.Dagger.ID)} or {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("darts", Items.RangedWeapons.Instances.Dart.ID)}; you can wield a playing card in all ways as the chosen weapon until the stance ends. As long as the majority of the deck remains in your possession, any cards that are lost or thrown can be found after 1 minute. Otherwise, the remaining cards are likely lost or destroyed." };
            yield return new TextBlock { Id = Guid.Parse("2561b515-50b3-435b-ae33-22c32accc997"), Type = TextBlockType.Text, Text = $"A character who has this feat can enchant a single deck of playing cards as a magic weapon, etching fundamental and property runes directly onto the deck of cards." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2aea4768-e98f-4be7-afd3-fed561048dba"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
