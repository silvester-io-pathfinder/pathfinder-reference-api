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
    public class Bones : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Mystery GetMystery()
        {
            return new Mystery
            {
                Id = ID,
                Name = "Bones",
                InitialRevelationId = Spells.Instances.SoulSiphon.ID,
                AdvancedRevelationId = Spells.Instances.ArmorOfBones.ID,
                GreaterRevelationId = Spells.Instances.ClaimUndead.ID,
                GrantedCantripId = Spells.Instances.ChillTouch.ID,
                TrainedSkillId = Skills.Instances.Medicine.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your mystery imparts an understanding of death and undeath in all their macabre complexity. You might have had a brush with death yourself—maybe even dying and returning to life—or carry the touch of undeath in your blood. If you commune with deities, you might speak with guardians of death like Pharasma and the psychopomp ushers (the most powerful among creatures that guide souls through the afterlife); a bringer of death like the Mantis God Achaekek or the Horseman of the Apocalypse Charon; or a herald of undeath such as Urgathoa." };
        }

        protected override IEnumerable<TextBlock> GetBenefitBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You can cleverly leverage the subtleties of life and death to your benefit. Each day during your preparations, you can choose to align yourself in the confluence of positive and negative energy so as to gain negative healing, which means you are harmed by positive damage and healed by negative effects as if you were undead. If you already have negative healing, instead the DC of your recovery checks is equal to 9 + your current dying value." };
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Death.ID;
            yield return Domains.Instances.Undeath.ID;
        }

        protected override MysteryCurse GetCurse()
        {
            return new MysteryCurse
            {
                Id = Guid.Parse(""),
                Name = "Curse of Living Death",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse(""),
                    SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                    Page = 75
                },
                Details = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your body is slowly decaying even though you are alive, and using your powers furthers this unnatural living death. You carry a touch of the grave about you, manifesting as bloodless pallor, a faint smell of earth, or deathly cold skin." }
                },
                Potencies = new MysteryCursePotency[]
                {
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse(""),
                        PotencyId = Potencies.Instances.Minor.ID,
                        Details = new TextBlock[] 
                        { 
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Bones protrude through your skin and your flesh rots, combining with a stench of decay and an unearthly chill. Non-magical effects that would restore your Hit Points only grant you half as many HP as normal." }
                        }
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse(""),
                        PotencyId = Potencies.Instances.Moderate.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your dead flesh continues to rot, affecting your health. You become drained 1, and this drained condition is cumulative with any other drained conditions you gain. This drained condition is removed only when you Refocus; effects that normally remove the drained condition reduce your drained condition to drained 1 instead. In addition, you gain resistance to poison equal to half your level. You gain a +4 status bonus to saves against diseases, poisons, and death effects, and if you roll a success on such a save, you get a critical success instead." }
                        }
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse(""),
                        PotencyId = Potencies.Instances.Major.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You stand just steps from the grave. You become wounded 1. This wounded condition is removed only when you Refocus; effects that normally remove the wounded condition reduce your wounded condition to wounded 1 instead. When you would attempt a recovery check, you can choose to get an automatic success instead of rolling, and if you roll a critical failure on a save against a disease, poison, or death effect, you get a failure instead." }
                        }
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
                Page = 75
            };
        }
    }
}
