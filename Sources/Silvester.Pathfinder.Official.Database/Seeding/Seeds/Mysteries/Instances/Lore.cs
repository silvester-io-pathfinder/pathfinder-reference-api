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
    public class Lore : Template
    {
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Knowledge and information come freely to you. You might use this lore to gain power or perhaps to understand the divine mysteries of the multiverse. You might have a conduit to the fabled Akashic Record, maintain a subtle telepathic connection to the collective subconscious of all living creatures, or follow in the footsteps of deities such as Abadar, Irori, Nethys, Irori's scholarly nephew Gruhastha, the fey triune goddess of fate Magdh, or the lawful aeon god-figure known as the Monad." };
        }

        protected override IEnumerable<TextBlock> GetBenefitBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You hold more mystical knowledge within you than most. You have one additional spell in your repertoire of each level you can cast." };
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
                Id = Guid.Parse(""),
                Name = "Curse of Torrential Knowledge",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse(""),
                    SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                    Page = 78
                },
                Details = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You have a link to true divine knowledge, but your mortal mind struggles to process and act on what you know. Loose materials around you, such as dust, grains of rice, and droplets of water, slowly shift to form strange runes or faint indecipherable writing, and you sometimes speak unintelligible truths or statements in unknown languages without realizing it." }
                },
                Potencies = new MysteryCursePotency[]
                {
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse(""),
                        PotencyId = Potencies.Instances.Minor.ID,
                        Details = new TextBlock[] 
                        { 
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You take a –4 penalty to initiative, as trying to process a surge of information about what's happening around you slows your ability to respond to it." }
                        }
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse(""),
                        PotencyId = Potencies.Instances.Moderate.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The flow of information through your mind grows. The attention you divert to process this huge influx of information means you are always flat-footed. At the start of each of your turns, you automatically make one check to Recall Knowledge as a free action. This uses a skill of your choice that has the Recall Knowledge action, using a result equal to 10 + your proficiency bonus in that skill (with no other bonuses, penalties, or modifiers)." }
                        }
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse(""),
                        PotencyId = Potencies.Instances.Major.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The massive flow of information clouding your mind overwhelms your ability to communicate with others. You can understand all languages, but you can't speak, use linguistic effects, or otherwise communicate with your allies. If you Cast a Spell with a verbal component, you must succeed at a DC 5 flat check or the spell is lost. You gain a +4 status bonus on saving throws against linguistic effects." }
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
