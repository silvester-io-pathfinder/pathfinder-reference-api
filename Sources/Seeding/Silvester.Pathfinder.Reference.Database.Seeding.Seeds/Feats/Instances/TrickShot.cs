using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TrickShot : Template
    {
        public static readonly Guid ID = Guid.Parse("542ac3a5-804b-402e-9e5c-d938827424c2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Trick Shot",
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
            yield return new TextBlock { Id = Guid.Parse("755c462c-4d5e-4996-84e8-a5952d8e46f7"), Type = TextBlockType.Text, Text = $"You shoot not at your foe but at an object nearby. Make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with your firearm against an AC equal to an easy DC for your level. On a success, instead of hitting your foe, your attack hits an object behind or to the side of your target, creating one of the following effects. The GM might determine that a different AC is appropriate or that a particular effect isn't a valid option, such as using the explosive barrel option when there's no such object on the battlefield. The GM should inform you if a Trick Shot is feasible before you spend your actions, since your trained eye can easily recognize loose or volatile objects." };
            yield return new TextBlock { Id = Guid.Parse("99a673b8-b090-4064-933e-aec9fcc36197"), Type = TextBlockType.Enumeration, Text = $" Dislodge Object: Your attack knocks an unattended object of no more than 2 Bulk out of position, moving it up to 10 feet in a direction of your choice. For example, the weapon could knock a wizard's crystal ball off a table." };
            yield return new TextBlock { Id = Guid.Parse("ad126e80-4de8-40fc-a582-e6b63f0d0f42"), Type = TextBlockType.Enumeration, Text = $" Explosive Barrel: Your attack strikes a barrel of expensive rum, a vial of volatile alchemical fluids, a demonic pustule erupting from the earth, or some other explosive object. The object explodes in a 20-foot burst, and creatures in the area take 6d6 damage with a basic Reflex save against your class DC. The damage type is chosen by the GM, based on the exploding object. Increase the damage by 1d6 for every 2 levels you have above 10th." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0c96fbeb-b1f9-47b7-bce3-4629543aeb6a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
