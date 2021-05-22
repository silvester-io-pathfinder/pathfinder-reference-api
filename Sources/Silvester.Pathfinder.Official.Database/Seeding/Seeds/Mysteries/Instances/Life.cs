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
    public class Life : Template
    {
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The never-ending flow of positive energy within living beings is palpable to you. You might uphold the sanctity of life, or perhaps you seek to undermine it. You might draw power from the collective vitality of the world's living creatures, hold some connection to the Positive Energy Plane, or revere a collection of deities including Irori, Pharasma, Sarenrae, and the god of medicine Qi Zhong." };
        }

        protected override IEnumerable<TextBlock> GetBenefitBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your body is a deep reservoir of life energy. At each level, you gain Hit Points equal to 10 + your Constitution modifier from the oracle class, instead of 8 + your Constitution modifier." };
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
                Id = Guid.Parse(""),
                Name = "Curse of Outpouring Life",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse(""),
                    SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                    Page = 77
                },
                Details = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Life energy flows outward from you and connects you to all living things, but you expend your vital essence to do so. Your presence comforts the ill and injured, causes scars to fade slightly, spurs new growth in plants, and otherwise infuses your surroundings with vitality." }
                },
                Potencies = new MysteryCursePotency[]
                {
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse(""),
                        PotencyId = Potencies.Instances.Minor.ID,
                        Details = new TextBlock[] 
                        { 
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "As your life force seeps outward, it becomes more difficult to keep your body functioning. Effects that restore Hit Points to you take a status penalty equal to half your level (minimum 1) to the number of HP you recover." }
                        }
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse(""),
                        PotencyId = Potencies.Instances.Moderate.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The flow of life energy away from you can't be reversed. In addition to the effects of your minor curse, you can't be healed by magical effects originating from other creatures. However, if you are unconscious, magical effects can restore you to 1 HP (but no higher). You are affected normally by healing elixirs, potions, and other items. When you cast heal and all your targets are living creatures, you roll d12s instead of d8s for the amount of healing." },
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Whenever you finish casting a non-cantrip spell, you restore Hit Points equal to the spell level to your choice of either one target of the spell or the creature nearest to you. You can't heal yourself in this way. This healing has the healing, necromancy, and positive traits, as well as the tradition trait of the spell." }
                        }
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse(""),
                        PotencyId = Potencies.Instances.Major.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Life energy tears through you to empower your magic. Some of your spells carry positive energy with them. Each time you use a spell slot to cast a 5th-level or higher spell that takes 2 or more actions to cast, you disperse positive energy in a 30-foot burst with the effects of a 3-action heal spell with a level 4 lower than that of the spell you cast. This healing occurs immediately after you finish Casting the Spell. You don't benefit from this healing. Instead, you lose double the number of Hit Points rolled for the heal spell." }
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
                Page = 77
            };
        }
    }
}
