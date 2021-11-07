using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MegatonStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("9f4de9fc-a226-4037-97fc-65350536b40c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Megaton Strike",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If your innovation is a minion, it can take this action rather than you.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("31a3b4da-5ebd-4e6a-aa2c-dad4ef6a746c"), Type = TextBlockType.Text, Text = "You activate gears, explosives, and other hidden mechanisms in your innovation to make a powerful attack. You make a (action: Strike), dealing an extra die of weapon damage. If you’re at least 10th level, increase this to two extra dice, and if you’re at least 18th level, increase it to three extra dice. The type of (action: Strike) you can make depends on your innovation." };
            yield return new TextBlock { Id = Guid.Parse("703d64d9-2cef-48ff-9617-2f87da444a2b"), Type = TextBlockType.Enumeration, Text = " Armor: You (action: Strike) with a melee unarmed attack or a melee weapon. To use a melee weapon for this, you must have prepared it in advance with special contraptions when you make your daily preparations." };
            yield return new TextBlock { Id = Guid.Parse("4fa58e30-8839-495e-abad-497fe30157a3"), Type = TextBlockType.Enumeration, Text = " Construct: Your minion innovation (action: Strikes | Strike)." };
            yield return new TextBlock { Id = Guid.Parse("bac6a077-ef1a-42bf-a2e8-0f83ebd9570f"), Type = TextBlockType.Enumeration, Text = " Weapon: You (action: Strike) with your weapon innovation." };
            yield return new TextBlock { Id = Guid.Parse("55b07773-1a07-4a64-97c5-8a6a97859eb8"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("fc15963f-e270-433f-af29-9f36b419200b"), Type = TextBlockType.Text, Text = "~ Unstable Function: You put even more force into the (action: Strike), though you risk stress fractures to your innovation. Add the (trait: unstable) trait to Megaton Strike. The (action: Strike) deals another extra damage die, for a total of two extra dice at 4th level, three at 10th level, and four at 18th level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("9a7d76cf-ead1-4e8b-84f7-4363a25e0113"), or => 
            {
                or.HaveSpecificInnovation(Guid.Parse("f85ae325-e0db-44fa-a03e-89699f02eb7a"), Innovations.Instances.Armor.ID);
                or.HaveSpecificInnovation(Guid.Parse("71251d95-216d-454d-a326-f17886f8cee9"), Innovations.Instances.Construct.ID);
                or.HaveSpecificInnovation(Guid.Parse("4dc21111-b71c-4574-b032-534d8b7bce98"), Innovations.Instances.Weapon.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5e0fd266-e04c-4e32-91bb-b13a3c13962b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
