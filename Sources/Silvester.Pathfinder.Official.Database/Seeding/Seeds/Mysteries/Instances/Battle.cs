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
        public static readonly Guid ID = Guid.Parse("95d646cf-1720-4c5b-ae7f-44879200011d");

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
            yield return new TextBlock { Id = Guid.Parse("7438d154-cb04-4c08-bc6f-477c04b0915e"), Type = TextBlockType.Text, Text = "Warlike forces fill you with physical might and tactical knowledge, aiming to have you uphold the glory of combat, fight to improve the world, prepare against the necessity of conflict, or endure the inevitability of war. You might draw upon deities such as Gorum, Iomedae, Rovagug, the Horseman of War Szuriel, the Queen of the Night Eiseth, the Vudrani god Diomazul, and others, or you might find power in the unending conflict between the armies of Heaven and Hell, the Elemental Planes, the Outer Gods, or even the collective spirits of those who fought in wars over the ages." };
        }

        protected override IEnumerable<TextBlock> GetBenefitBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a9c23bd7-9605-4568-9197-98b1caa1101c"), Type = TextBlockType.Text, Text = "You are no stranger to the trappings of warfare. You are trained in medium and heavy armor. At 13th level, if you gain the light armor expertise class feature, you also gain expert proficiency in these armors." };
            yield return new TextBlock { Id = Guid.Parse("a941cf6e-eea5-4b8d-b19a-e661b21ee0b0"), Type = TextBlockType.Text, Text = "Choose one weapon group that embodies your mystery. You are trained in all martial weapons of that group. At 11th level, if you gain the weapon expertise class feature, you also gain expert proficiency for martial weapons in your chosen group, and you become trained in advanced weapons in that group." };
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
                Id = Guid.Parse("85727c5e-09d9-4327-a74a-5aaef5e9f3fa"),
                Name = "Curse of the Hero's Burden",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("895dbe63-a701-4074-b939-52fee198f6be"),
                    SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                    Page = 74
                },
                Details = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("3eac266c-7762-41c8-b0a1-4bffcabf9fb0"), Type = TextBlockType.Text, Text = "You thrive while adrenaline flows and your life depends on your might alone, but holding the collective battle prowess of the ages within you leaves your body weakened after a fight. You smell faintly of steel and blood no matter how you try to remove or mask the scent, you appear more muscular than you actually are, and you hear the faint clash and clamor of battle in the distance at all times." }
                },
                Potencies = new MysteryCursePotency[]
                {
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse("d9fc7ff0-2b5f-48eb-9588-9ce7690d215a"),
                        PotencyId = Potencies.Instances.Minor.ID,
                        Details = new TextBlock[] 
                        { 
                            new TextBlock { Id = Guid.Parse("0b2e5506-d47b-4d53-80a4-0c64af10541a"), Type = TextBlockType.Text, Text = "Your body languishes when you aren't bringing harm to your foes. You take a –2 status penalty to AC and saving throws, but each time you make a Strike, you can suspend these penalties until the start of your next turn." }
                        },
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse("85493ff7-09fc-43eb-a5c4-06f465d92a80"),
                        PotencyId = Potencies.Instances.Moderate.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse("7206f308-6289-4942-87d2-f147258dde60"), Type = TextBlockType.Text, Text = "The strain of conflict wears upon your body, even though you gain vitality from it. Making a Strike reduces the penalty from your minor curse to –1 rather than suspending it entirely. You gain a +2 status bonus to weapon and unarmed damage rolls. You also gain fast healing equal to half your level while in a non-trivial combat encounter." }
                        },
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse("1ddb07db-6c9e-4054-9c40-bd771cc69ecf"),
                        PotencyId = Potencies.Instances.Major.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse("7dfe06b3-37d9-4b6c-aac7-bb09869504ed"), Type = TextBlockType.Text, Text = "Your body proves capable of truly heroic feats, but doing so interferes with your mental focus. Your moderate curse's fast healing is equal to your level, and its damage bonus is +6. You gain a +1 status bonus to weapon and unarmed attack rolls, but you are stupefied 2." }
                        },
                    }
                },
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8662fe62-f3e2-4d9f-b6d5-4bd5efcf3831"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 74
            };
        }
    }
}
