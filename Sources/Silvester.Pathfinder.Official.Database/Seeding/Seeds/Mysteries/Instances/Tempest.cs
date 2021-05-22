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
    public class Tempest : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Mystery GetMystery()
        {
            return new Mystery
            {
                Id = ID,
                Name = "Tempest",
                InitialRevelationId = Spells.Instances.TempestTouch.ID,
                AdvancedRevelationId = Spells.Instances.Thunderburst.ID,
                GreaterRevelationId = Spells.Instances.TempestForm.ID,
                GrantedCantripId = Spells.Instances.ElectricArc.ID,
                TrainedSkillId = Skills.Instances.Nature.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The fury of the wind and waves pounds in your heart, whether your power flows from natural storms, a conduit to the elemental Planes of Air and Water, or through reverence of deities such as Gozreh, the tengu god of storms Hei Feng, the demon lord Dagon, or the elemental lords of air and water." };
        }

        protected override IEnumerable<TextBlock> GetBenefitBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You can see perfectly through wind and water, and you send electric charges through both air and water. You never take penalties to Perception from wind, rain, fog, or other precipitation, or from looking through water or being underwater, and such conditions don't cause anything to be concealed from you." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When you deal physical damage with a non-cantrip air or water spell, you deal an additional 1 electricity damage per spell level." };
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Air.ID;
            yield return Domains.Instances.Water.ID;
        }

        protected override MysteryCurse GetCurse()
        {
            return new MysteryCurse
            {
                Id = Guid.Parse(""),
                Name = "Curse of the Perpetual Storm",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse(""),
                    SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                    Page = 78
                },
                Details = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You are the center of your own tiny tempest, ever surrounded by wind and rain that worsens the more you tap into your elemental powers. Even when you are calm and at rest, your hair and clothing are blown about by gentle winds, you are slightly damp, and your touch often comes with a static shock." }
                },
                Potencies = new MysteryCursePotency[]
                {
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse(""),
                        PotencyId = Potencies.Instances.Minor.ID,
                        Details = new TextBlock[] 
                        { 
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "An aura of a whirling storm whips up in a 5-foot emanation around you and in your space. The aura puts out small non-magical fires 1 round after they're lit or brought into your aura." },
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Electrical energy builds up within your storm, turning you into a lightning rod; you gain weakness 2 to electricity, and electricity spells or effects that have additional effects for a creature wearing or holding metal treat you as though you were wearing metal." }
                        }
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse(""),
                        PotencyId = Potencies.Instances.Moderate.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your minor curse's aura expands to a 10- foot emanation and carries rain on the winds. The whirling winds impose a –2 circumstance penalty on ranged attack rolls using physical ammunition that target you or originate from you. Your weakness to electricity increases to 5 or half your level, whichever is greater, but torrential rain grants you an equal amount of fire resistance." }
                        }
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse(""),
                        PotencyId = Potencies.Instances.Major.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your minor curse's aura expands to a 15-foot emanation and grows stronger. High winds blowing outward in the aura impede creatures' progress. The aura is difficult terrain for Large and smaller creatures on the ground, and for Huge or smaller flying creatures. You aren't affected by this difficult terrain." },
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The electricity arcing through you becomes dangerous. Any creature that touches you, including with a touch spell or a melee unarmed attack, takes 1d6 electricity damage." }
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
                Page = 78
            };
        }
    }
}
