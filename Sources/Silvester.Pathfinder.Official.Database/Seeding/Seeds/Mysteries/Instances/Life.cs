using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Mysteries.Instances
{
    public class Life : Template
    {
        public static readonly Guid ID = Guid.Parse("b0b78c19-7a13-49fb-9a34-7d04765b78cf");

        protected override Mystery GetMystery()
        {
            return new Mystery
            {
                Id = ID,
                Name = "Life",
                InitialRevelationId = Spells.Instances.LifeLink.ID,
                AdvancedRevelationId = Spells.Instances.DelayAffliction.ID,
                GreaterRevelationId = Spells.Instances.LifeGivingForm.ID,
                GrantedCantripId = Spells.Instances.Stabilize.ID,
                TrainedSkillId = Skills.Instances.Medicine.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d2f612f4-6c77-450d-83cb-7f12562153d9"), Type = TextBlockType.Text, Text = "The never-ending flow of positive energy within living beings is palpable to you. You might uphold the sanctity of life, or perhaps you seek to undermine it. You might draw power from the collective vitality of the world's living creatures, hold some connection to the Positive Energy Plane, or revere a collection of deities including Irori, Pharasma, Sarenrae, and the god of medicine Qi Zhong." };
        }

        protected override IEnumerable<TextBlock> GetBenefitBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c1509858-4554-4c0b-89a0-f68bd1c2781d"), Type = TextBlockType.Text, Text = "Your body is a deep reservoir of life energy. At each level, you gain Hit Points equal to 10 + your Constitution modifier from the oracle class, instead of 8 + your Constitution modifier." };
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Death.ID;
            yield return Domains.Instances.Healing.ID;
        }

        protected override MysteryCurse GetCurse()
        {
            return new MysteryCurse
            {
                Id = Guid.Parse("c55a6e81-21e1-4496-8800-d8636afd7e79"),
                Name = "Curse of Outpouring Life",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("600eebfe-3122-441d-9f9a-14395a87cf49"),
                    SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                    Page = 77
                },
                Details = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("4c9bccc4-0ac6-488c-82bb-6e89944e554b"), Type = TextBlockType.Text, Text = "Life energy flows outward from you and connects you to all living things, but you expend your vital essence to do so. Your presence comforts the ill and injured, causes scars to fade slightly, spurs new growth in plants, and otherwise infuses your surroundings with vitality." }
                },
                Potencies = new MysteryCursePotency[]
                {
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse("86a4a3b5-2575-4e6a-9b7f-ca5983ac22da"),
                        PotencyId = Potencies.Instances.Minor.ID,
                        Details = new TextBlock[] 
                        { 
                            new TextBlock { Id = Guid.Parse("2e07c324-6bfc-402f-8813-388506567244"), Type = TextBlockType.Text, Text = "As your life force seeps outward, it becomes more difficult to keep your body functioning. Effects that restore Hit Points to you take a status penalty equal to half your level (minimum 1) to the number of HP you recover." }
                        }
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse("9923a516-847d-454e-857c-1e8f6b1f99a5"),
                        PotencyId = Potencies.Instances.Moderate.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse("9462bbd7-6333-42a9-bd5c-0c5701c5cc7f"), Type = TextBlockType.Text, Text = "The flow of life energy away from you can't be reversed. In addition to the effects of your minor curse, you can't be healed by magical effects originating from other creatures. However, if you are unconscious, magical effects can restore you to 1 HP (but no higher). You are affected normally by healing elixirs, potions, and other items. When you cast heal and all your targets are living creatures, you roll d12s instead of d8s for the amount of healing." },
                            new TextBlock { Id = Guid.Parse("e6af43b8-904b-40b4-86f4-1f55df8e5170"), Type = TextBlockType.Text, Text = "Whenever you finish casting a non-cantrip spell, you restore Hit Points equal to the spell level to your choice of either one target of the spell or the creature nearest to you. You can't heal yourself in this way. This healing has the healing, necromancy, and positive traits, as well as the tradition trait of the spell." }
                        }
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse("c8f27630-ab7f-4132-b14d-328a2c6761c6"),
                        PotencyId = Potencies.Instances.Major.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse("2f5f1468-b46e-47ac-a77e-fa5649011684"), Type = TextBlockType.Text, Text = "Life energy tears through you to empower your magic. Some of your spells carry positive energy with them. Each time you use a spell slot to cast a 5th-level or higher spell that takes 2 or more actions to cast, you disperse positive energy in a 30-foot burst with the effects of a 3-action heal spell with a level 4 lower than that of the spell you cast. This healing occurs immediately after you finish Casting the Spell. You don't benefit from this healing. Instead, you lose double the number of Hit Points rolled for the heal spell." }
                        }
                    }
                },
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2402e6ac-f85a-44b1-b3d1-f0d28e724615"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 77
            };
        }
    }
}
