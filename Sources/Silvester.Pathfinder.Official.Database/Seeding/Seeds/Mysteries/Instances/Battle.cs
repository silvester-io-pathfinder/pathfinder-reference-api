using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Tables;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Mysteries.Instances
{
    public class Battle : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Mystery GetMystery()
        {
            return new Mystery
            {
                Id = ID,
                Name = "Battle",
                InitialRevelationId = Spells.Instances.CallToArms.ID,
                AdvancedRevelationId = Spells.Instances.BattlefieldPersistence.ID,
                GreaterRevelationId = Spells.Instances.HeroicFeat.ID,
                GrantedCantripId = Spells.Instances.Shield.ID,
                TrainedSkillId = Skills.Instances.Athletics.ID
            };
        }

        protected  override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Warlike forces fill you with physical might and tactical knowledge, aiming to have you uphold the glory of combat, fight to improve the world, prepare against the necessity of conflict, or endure the inevitability of war. You might draw upon deities such as Gorum, Iomedae, Rovagug, the Horseman of War Szuriel, the Queen of the Night Eiseth, the Vudrani god Diomazul, and others, or you might find power in the unending conflict between the armies of Heaven and Hell, the Elemental Planes, the Outer Gods, or even the collective spirits of those who fought in wars over the ages." };
        }

        protected override IEnumerable<TextBlock> GetBenefitBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You are no stranger to the trappings of warfare. You are trained in medium and heavy armor. At 13th level, if you gain the light armor expertise class feature, you also gain expert proficiency in these armors." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Choose one weapon group that embodies your mystery. You are trained in all martial weapons of that group. At 11th level, if you gain the weapon expertise class feature, you also gain expert proficiency for martial weapons in your chosen group, and you become trained in advanced weapons in that group." };
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Might.ID;
            yield return Domains.Instances.Zeal.ID;
        }

        protected override MysteryCurse GetCurse()
        {
            return new MysteryCurse
            {
                Id = Guid.Parse(""),
                Name = "Curse of the Hero's Burden",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse(""),
                    SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                    Page = 74
                },
                Details = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You thrive while adrenaline flows and your life depends on your might alone, but holding the collective battle prowess of the ages within you leaves your body weakened after a fight. You smell faintly of steel and blood no matter how you try to remove or mask the scent, you appear more muscular than you actually are, and you hear the faint clash and clamor of battle in the distance at all times." }
                },
                Potencies = new MysteryCursePotency[]
                {
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse(""),
                        PotencyId = Potencies.Instances.Minor.ID,
                        Details = new TextBlock[] 
                        { 
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your body languishes when you aren't bringing harm to your foes. You take a –2 status penalty to AC and saving throws, but each time you make a Strike, you can suspend these penalties until the start of your next turn." }
                        },
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse(""),
                        PotencyId = Potencies.Instances.Moderate.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The strain of conflict wears upon your body, even though you gain vitality from it. Making a Strike reduces the penalty from your minor curse to –1 rather than suspending it entirely. You gain a +2 status bonus to weapon and unarmed damage rolls. You also gain fast healing equal to half your level while in a non-trivial combat encounter." }
                        },
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse(""),
                        PotencyId = Potencies.Instances.Major.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your body proves capable of truly heroic feats, but doing so interferes with your mental focus. Your moderate curse's fast healing is equal to your level, and its damage bonus is +6. You gain a +1 status bonus to weapon and unarmed attack rolls, but you are stupefied 2." }
                        },
                    }
                },
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 74
            };
        }
    }
}
