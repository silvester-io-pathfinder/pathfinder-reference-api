using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Mysteries.Instances
{
    public class Lore : Template
    {
        public static readonly Guid ID = Guid.Parse("1814b4e8-edc9-4dd8-958d-3dbe7e3fe3b1");

        protected override Mystery GetMystery()
        {
            return new Mystery
            {
                Id = ID,
                Name = "Lore",
                InitialRevelationId = Spells.Instances.BrainDrain.ID,
                AdvancedRevelationId = Spells.Instances.AccessLore.ID,
                GreaterRevelationId = Spells.Instances.DreadSecret.ID,
                GrantedCantripId = Spells.Instances.ReadAura.ID,
                TrainedSkillId = Skills.Instances.Occultism.ID,
                TrainedSkillAddendum = "Besides Occultism, you gain one Lore skill of your choice."
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("949f0bd4-628e-438b-8dd0-97a09c5a93b8"), Type = TextBlockType.Text, Text = "Knowledge and information come freely to you. You might use this lore to gain power or perhaps to understand the divine mysteries of the multiverse. You might have a conduit to the fabled Akashic Record, maintain a subtle telepathic connection to the collective subconscious of all living creatures, or follow in the footsteps of deities such as Abadar, Irori, Nethys, Irori's scholarly nephew Gruhastha, the fey triune goddess of fate Magdh, or the lawful aeon god-figure known as the Monad." };
        }

        protected override IEnumerable<TextBlock> GetBenefitBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eb2dc91c-a278-4b7a-ac1d-a83b855a63c7"), Type = TextBlockType.Text, Text = "You hold more mystical knowledge within you than most. You have one additional spell in your repertoire of each level you can cast." };
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Truth.ID;
        }

        protected override MysteryCurse GetCurse()
        {
            return new MysteryCurse
            {
                Id = Guid.Parse("6127c7b5-b41e-4f2f-92de-fea98126712f"),
                Name = "Curse of Torrential Knowledge",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("ebbe9813-c1b4-4de3-9766-218cd9f982b7"),
                    SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                    Page = 78
                },
                Details = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("ad1887df-7608-4948-a701-f7eebae85769"), Type = TextBlockType.Text, Text = "You have a link to true divine knowledge, but your mortal mind struggles to process and act on what you know. Loose materials around you, such as dust, grains of rice, and droplets of water, slowly shift to form strange runes or faint indecipherable writing, and you sometimes speak unintelligible truths or statements in unknown languages without realizing it." }
                },
                Potencies = new MysteryCursePotency[]
                {
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse("dc0d9aaa-846f-4fb1-be19-ddf7e674e385"),
                        PotencyId = Potencies.Instances.Minor.ID,
                        Details = new TextBlock[] 
                        { 
                            new TextBlock { Id = Guid.Parse("64cb77dc-00c4-4568-b7b8-d86af155cb32"), Type = TextBlockType.Text, Text = "You take a –4 penalty to initiative, as trying to process a surge of information about what's happening around you slows your ability to respond to it." }
                        }
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse("f9a9d796-733e-483e-8d8a-7f244f122252"),
                        PotencyId = Potencies.Instances.Moderate.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse("b11a478e-e3ea-4c62-8861-11eb91dd8d37"), Type = TextBlockType.Text, Text = "The flow of information through your mind grows. The attention you divert to process this huge influx of information means you are always flat-footed. At the start of each of your turns, you automatically make one check to Recall Knowledge as a free action. This uses a skill of your choice that has the Recall Knowledge action, using a result equal to 10 + your proficiency bonus in that skill (with no other bonuses, penalties, or modifiers)." }
                        }
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse("cdb44a44-0d29-4d10-b7e8-ae3ad7c9f8db"),
                        PotencyId = Potencies.Instances.Major.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse("470b2884-6871-4da2-ac25-e27474837dd3"), Type = TextBlockType.Text, Text = "The massive flow of information clouding your mind overwhelms your ability to communicate with others. You can understand all languages, but you can't speak, use linguistic effects, or otherwise communicate with your allies. If you Cast a Spell with a verbal component, you must succeed at a DC 5 flat check or the spell is lost. You gain a +4 status bonus on saving throws against linguistic effects." }
                        }
                    }
                },
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0aedfff-f694-41d5-aca1-839f8a92dba2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 77
            };
        }
    }
}
