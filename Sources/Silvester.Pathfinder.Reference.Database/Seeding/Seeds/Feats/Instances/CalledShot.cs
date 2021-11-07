using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CalledShot : Template
    {
        public static readonly Guid ID = Guid.Parse("e9c18756-7d3d-4a2e-bfab-9e7fa24e0247");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Called Shot",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("411613da-2fa9-4806-9af7-5f4f488b2edd"), Type = TextBlockType.Text, Text = "You target a specific area of your foe’s anatomy to debilitating effect. Declare a part of your foe’s anatomy to target and make a ranged weapon (action: Strike). If you hit and deal damage, the target takes one of the following effects, based on the body part you targeted. The GM should use the stated effects as a guideline when attacking creatures with stranger anatomy—for instance, applying the “arms” effect to a creature’s tentacles if those are what the creature uses to attack." };
            yield return new TextBlock { Id = Guid.Parse("a7aeec7e-bb88-46f6-9282-c393ecb1b0a6"), Type = TextBlockType.Enumeration, Text = " Arms: The target is enfeebled 2 until the end of your next turn. On a critical hit, it’s also enfeebled 1 for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("e1a87636-d07c-47fc-80a6-c68a7eaad3a5"), Type = TextBlockType.Enumeration, Text = " Head: The target is stupefied 2 until the end of your next turn. On a critical hit, it’s also stupefied 1 for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("1f9570fc-7b5f-40d4-ac4d-90611f9ce126"), Type = TextBlockType.Enumeration, Text = " Legs: The target takes a –10-foot status penalty to its Speeds until the end of your next turn. On a critical hit, it also takes a –5-foot penalty to its Speeds for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("de687f53-0735-44b0-afbb-d94ae350b7ce"), Type = TextBlockType.Enumeration, Text = " Wings: If the target is flying using its wings, it immediately falls 20 feet, or 40 feet on a critical hit. The fall is gradual enough that if the target hits the ground, it takes no damage from the fall." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9bf4d644-c389-4bbc-a399-88386bdaf59a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
