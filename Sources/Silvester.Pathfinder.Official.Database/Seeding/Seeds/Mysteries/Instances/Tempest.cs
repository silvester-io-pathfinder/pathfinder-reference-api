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
        public static readonly Guid ID = Guid.Parse("4875ca50-6a42-4025-bb6d-d8d978dfe0fc");

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
            yield return new TextBlock { Id = Guid.Parse("8701e1d8-2ae2-4d05-8939-3603602c58e8"), Type = TextBlockType.Text, Text = "The fury of the wind and waves pounds in your heart, whether your power flows from natural storms, a conduit to the elemental Planes of Air and Water, or through reverence of deities such as Gozreh, the tengu god of storms Hei Feng, the demon lord Dagon, or the elemental lords of air and water." };
        }

        protected override IEnumerable<TextBlock> GetBenefitBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("69ff1f3f-cd63-40f9-8a6c-a5bf88d23ab5"), Type = TextBlockType.Text, Text = "You can see perfectly through wind and water, and you send electric charges through both air and water. You never take penalties to Perception from wind, rain, fog, or other precipitation, or from looking through water or being underwater, and such conditions don't cause anything to be concealed from you." };
            yield return new TextBlock { Id = Guid.Parse("ff77ccf3-c383-4e5e-bc34-1b290d21e5b2"), Type = TextBlockType.Text, Text = "When you deal physical damage with a non-cantrip air or water spell, you deal an additional 1 electricity damage per spell level." };
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
                Id = Guid.Parse("89400a72-2d2b-447f-9614-a009afff3252"),
                Name = "Curse of the Perpetual Storm",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("ad46e9ae-86c4-4a2c-afd1-4e50161179dd"),
                    SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                    Page = 78
                },
                Details = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("fa35d31b-e15a-481b-a82b-eb9cdf264513"), Type = TextBlockType.Text, Text = "You are the center of your own tiny tempest, ever surrounded by wind and rain that worsens the more you tap into your elemental powers. Even when you are calm and at rest, your hair and clothing are blown about by gentle winds, you are slightly damp, and your touch often comes with a static shock." }
                },
                Potencies = new MysteryCursePotency[]
                {
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse("8a9d4535-35e3-4fc0-889d-72baefc744da"),
                        PotencyId = Potencies.Instances.Minor.ID,
                        Details = new TextBlock[] 
                        { 
                            new TextBlock { Id = Guid.Parse("55b12b00-667d-4bc1-83f6-370a8839c76f"), Type = TextBlockType.Text, Text = "An aura of a whirling storm whips up in a 5-foot emanation around you and in your space. The aura puts out small non-magical fires 1 round after they're lit or brought into your aura." },
                            new TextBlock { Id = Guid.Parse("0b20de39-4828-4255-b6c6-32b1fd0e2216"), Type = TextBlockType.Text, Text = "Electrical energy builds up within your storm, turning you into a lightning rod; you gain weakness 2 to electricity, and electricity spells or effects that have additional effects for a creature wearing or holding metal treat you as though you were wearing metal." }
                        }
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse("28c9cb53-f4a3-4978-87e9-29a6a0ec92af"),
                        PotencyId = Potencies.Instances.Moderate.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse("0f5dc49b-c080-41fb-963a-11240509aea3"), Type = TextBlockType.Text, Text = "Your minor curse's aura expands to a 10- foot emanation and carries rain on the winds. The whirling winds impose a –2 circumstance penalty on ranged attack rolls using physical ammunition that target you or originate from you. Your weakness to electricity increases to 5 or half your level, whichever is greater, but torrential rain grants you an equal amount of fire resistance." }
                        }
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse("804e2102-9653-4d38-acc4-9ed2fea7566a"),
                        PotencyId = Potencies.Instances.Major.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse("cab28f44-e479-42cb-a99a-3551ae300006"), Type = TextBlockType.Text, Text = "Your minor curse's aura expands to a 15-foot emanation and grows stronger. High winds blowing outward in the aura impede creatures' progress. The aura is difficult terrain for Large and smaller creatures on the ground, and for Huge or smaller flying creatures. You aren't affected by this difficult terrain." },
                            new TextBlock { Id = Guid.Parse("d8331838-4d95-4a24-b4ec-f42b56c1ba41"), Type = TextBlockType.Text, Text = "The electricity arcing through you becomes dangerous. Any creature that touches you, including with a touch spell or a melee unarmed attack, takes 1d6 electricity damage." }
                        }
                    }
                },
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("96db2f44-0b33-4855-879f-e44e71409aab"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 78
            };
        }
    }
}
