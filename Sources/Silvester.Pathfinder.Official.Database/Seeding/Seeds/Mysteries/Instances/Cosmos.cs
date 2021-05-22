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
    public class Cosmos : Template
    {
        public static readonly Guid ID = Guid.Parse("aff38e17-5143-4499-9a7b-eeadf5205495");

        protected override Mystery GetMystery()
        {
            return new Mystery
            {
                Id = ID,
                Name = "Cosmos",
                InitialRevelationId = Spells.Instances.SprayOfStars.ID,
                AdvancedRevelationId = Spells.Instances.InterstellarVoid.ID,
                GreaterRevelationId = Spells.Instances.MoonlightBridge.ID,
                GrantedCantripId = Spells.Instances.DancingLights.ID,
                TrainedSkillId = Skills.Instances.Nature.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("18b42df5-2d06-4fff-96b0-b70487ea09d6"), Type = TextBlockType.Text, Text = "Celestial bodies great and small exert influence on you, giving you sublime cosmic power. Perhaps you see the glittering stars as a divine blessing, or perhaps you feel drawn to the infinitely dark spaces between. You might uphold deities like Desna, Sarenrae, or the deific lovers Shizuru and Tsukiyo who represent the sun and the moon—or you might draw power from dark entities from beyond the stars, like certain Outer Gods, or destructive gods of the night like Zon-Kuthon or the rat goddess Lao Shu Po." };
        }

        protected override IEnumerable<TextBlock> GetBenefitBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1696e194-5fea-4e53-bec3-efafc8ae1116"), Type = TextBlockType.Text, Text = "Your body is as much an astronomical one as it is physical. You gain resistance equal to 2 + half your level against all physical damage." };
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Darkness.ID;
            yield return Domains.Instances.Moon.ID;
        }

        protected override MysteryCurse GetCurse()
        {
            return new MysteryCurse
            {
                Id = Guid.Parse("05e1db20-e0ed-4827-917e-47397da756cc"),
                Name = "Curse of the Sky's Call",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("cb479576-d2b3-44ec-bdd7-6d3a1e974d45"),
                    SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                    Page = 75
                },
                Details = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("d9167484-f379-4fcf-a037-87c8d64040da"), Type = TextBlockType.Text, Text = "You have your head in the clouds—and not just figuratively. Your body is drawn toward the heavens, making you lighter and less substantial than you should be. Your eyes glow with starry light, and your hair and clothing float and drift around you." }
                },
                Potencies = new MysteryCursePotency[]
                {
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse("25b83e5a-63b5-4a4e-b1ee-4bb6fb7d628f"),
                        PotencyId = Potencies.Instances.Minor.ID,
                        Details = new TextBlock[] 
                        { 
                            new TextBlock { Id = Guid.Parse("c8db508d-e966-42ea-8621-190e05f14822"), Type = TextBlockType.Text, Text = "Your unnatural lightness makes it hard to keep your footing and interact with other physical objects. You are enfeebled 1 and take a –2 penalty to saves and DCs against Grapple, Shove, and other forms of forced movement." }
                        }
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse("4a57b852-aa91-47fa-8137-c2a6b0ca851e"),
                        PotencyId = Potencies.Instances.Moderate.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse("3e280ec0-19b9-4096-a069-410f8c6252ff"), Type = TextBlockType.Text, Text = "Your body is drawn further skyward. You are enfeebled 2, and the penalty from your minor curse increases to –3. You are treated as one size smaller for wind effects. You gain a +2 status bonus against Trip attempts, you only take half as much damage from falls, and you gain the effects of the Powerful Leap and Quick Jump skill feats. You weigh only half as much, and your Bulk, should someone need to carry you, is also half as much." }
                        }
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse("0d131a1c-5951-4909-a5e2-62ee3b370d6a"),
                        PotencyId = Potencies.Instances.Major.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse("56f4fa71-ff0d-49b1-b5a4-dd3398b993cd"), Type = TextBlockType.Text, Text = "As your body rises, you float just above the ground beneath you. You become enfeebled 4, and the penalty from your minor curse increases to –4. You can walk on liquids as if they were solid; you gain the effects of the Cloud Jump skill feat; and you don't leave tracks, trigger weight-sensitive pressure plates, or otherwise connect with the ground below you." }
                        }
                    }
                },
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0da13e25-db85-45b0-81f5-697116ec3fdd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 75
            };
        }
    }
}
