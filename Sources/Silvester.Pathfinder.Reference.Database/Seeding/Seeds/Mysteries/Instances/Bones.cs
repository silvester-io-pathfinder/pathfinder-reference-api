using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Mysteries.Instances
{
    public class Bones : Template
    {
        public static readonly Guid ID = Guid.Parse("9ca06a26-bfe0-4599-abac-9050dec1a9a9");

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
            yield return new TextBlock { Id = Guid.Parse("5c50fd1d-ebd4-483d-b353-9175ebf42dad"), Type = TextBlockType.Text, Text = "Your mystery imparts an understanding of death and undeath in all their macabre complexity. You might have had a brush with death yourself—maybe even dying and returning to life—or carry the touch of undeath in your blood. If you commune with deities, you might speak with guardians of death like Pharasma and the psychopomp ushers (the most powerful among creatures that guide souls through the afterlife); a bringer of death like the Mantis God Achaekek or the Horseman of the Apocalypse Charon; or a herald of undeath such as Urgathoa." };
        }

        protected override IEnumerable<TextBlock> GetBenefitBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("692d688c-38e6-4e87-b5cc-2bc78c17ec3f"), Type = TextBlockType.Text, Text = "You can cleverly leverage the subtleties of life and death to your benefit. Each day during your preparations, you can choose to align yourself in the confluence of positive and negative energy so as to gain negative healing, which means you are harmed by positive damage and healed by negative effects as if you were undead. If you already have negative healing, instead the DC of your recovery checks is equal to 9 + your current dying value." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Mystery Benefits
            //TODO: Add effect.

            //Trained Skill
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Medicine.ID);

            //Granted Cantrip
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ChillTouch.ID);

            //Initial Revelation Spell
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.SoulSiphon.ID);

            //Advanced Revelation Spell
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ArmorOfBones.ID)
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificFeat(Guid.Parse(""), Feats.Instances.AdvancedRevelation.ID);
                });

            //Greater Revelation Spell
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ClaimUndead.ID)
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificFeat(Guid.Parse(""), Feats.Instances.GreaterRevelation.ID);
                });
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
                Id = Guid.Parse("e3e28a10-57e2-46e0-9c99-862cddbba90c"),
                Name = "Curse of Living Death",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("d707259e-8eb5-4b8b-b9c8-ab57cb3cbb16"),
                    SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                    Page = 75
                },
                Details = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("82a9d1b4-5ace-418c-a628-fa559985a06e"), Type = TextBlockType.Text, Text = "Your body is slowly decaying even though you are alive, and using your powers furthers this unnatural living death. You carry a touch of the grave about you, manifesting as bloodless pallor, a faint smell of earth, or deathly cold skin." }
                },
                Potencies = new MysteryCursePotency[]
                {
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse("5cf40f93-3146-457f-ad00-f97a7de1d6ef"),
                        PotencyId = Potencies.Instances.Minor.ID,
                        Details = new TextBlock[] 
                        { 
                            new TextBlock { Id = Guid.Parse("71193f5e-96d2-4a63-8121-9342d26404ec"), Type = TextBlockType.Text, Text = "Bones protrude through your skin and your flesh rots, combining with a stench of decay and an unearthly chill. Non-magical effects that would restore your Hit Points only grant you half as many HP as normal." }
                        }
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse("1025db72-41b6-4772-8498-e2742f985d3a"),
                        PotencyId = Potencies.Instances.Moderate.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse("8b2d81e6-e6a5-4947-8ab5-64d6b2db9418"), Type = TextBlockType.Text, Text = "Your dead flesh continues to rot, affecting your health. You become drained 1, and this drained condition is cumulative with any other drained conditions you gain. This drained condition is removed only when you Refocus; effects that normally remove the drained condition reduce your drained condition to drained 1 instead. In addition, you gain resistance to poison equal to half your level. You gain a +4 status bonus to saves against diseases, poisons, and death effects, and if you roll a success on such a save, you get a critical success instead." }
                        }
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse("53a25cc7-3ad6-422b-b99e-77fafcc592b9"),
                        PotencyId = Potencies.Instances.Major.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse("495e09da-1753-46d7-978f-e06fc70a19cc"), Type = TextBlockType.Text, Text = "You stand just steps from the grave. You become wounded 1. This wounded condition is removed only when you Refocus; effects that normally remove the wounded condition reduce your wounded condition to wounded 1 instead. When you would attempt a recovery check, you can choose to get an automatic success instead of rolling, and if you roll a critical failure on a save against a disease, poison, or death effect, you get a failure instead." }
                        }
                    }
                },
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bd912346-6bf3-4a6b-94ed-70a667137435"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 75
            };
        }
    }
}
