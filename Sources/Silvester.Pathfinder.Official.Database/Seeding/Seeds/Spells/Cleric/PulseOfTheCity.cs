using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class PulseOfTheCity : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Pulse of the City",
                Level = 4,
                Range = "25 miles.",
                DomainId = Domains.Instances.Cities.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You tap into the zeitgeist of the nearest settlement in range (if any). You learn the name of the settlement, and you can utter a special word to learn a brief summary of one significant event happening in the settlement. Choose one of the following words, which indicates the type of people involved and type of event you learn about." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Wardens - City guards, barristers, and judges (criminal reports, busts, changes in routines, legal trials)" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Titles - Nobles and politicians (high society weddings, elite soirees, political rallies)" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Masses - Common folk and merchants (gathering mobs, major sales)" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When uttering your word, you can exclude events you already know about, whether you know about them from this spell or from other experiences. If you cast pulse of the city again within 24 hours, you can say “echo” instead of another word to get an update on the event you learned about the last time you Cast the Spell." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Pulse of the city reveals only publicly available or observable information. You never learn clandestine movements or other details people are specifically trying to hide. The spell is also notoriously bad at overcoming magic meant to avoid detection; it automatically fails to reveal information about events involving creatures, places, or objects affected by spells that could prevent or counteract pulse of the city (such as nondetection)." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The range increases to 100 miles." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Scrying.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 395
            };
        }
    }
}
