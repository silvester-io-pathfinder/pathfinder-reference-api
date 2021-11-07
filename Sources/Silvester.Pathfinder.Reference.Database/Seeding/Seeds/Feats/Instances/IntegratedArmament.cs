using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IntegratedArmament : Template
    {
        public static readonly Guid ID = Guid.Parse("539b5fc3-de30-4f7f-be2f-e393fdd8f7f2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Integrated Armament",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("464580b7-0060-4830-bdb6-7934a6717fe9"), Type = TextBlockType.Text, Text = "Your mechanical body houses a weapon or shield that you can quickly draw and stow, leaving you prepared for combat at all times." };
            yield return new TextBlock { Id = Guid.Parse("aa2fcc1e-f32e-49bd-bcea-aa429c582522"), Type = TextBlockType.Text, Text = "You can use a 1-minute activity, which has the (trait: manipulate) trait, to integrate a single, one-handed weapon or shield into one of your arms. You can draw or stow this item as an (action: Interact) action. Creatures don’t automatically see this integrated item when it’s stowed and must actively (action: Seek) in order to find it. They take a –2 circumstance penalty to any checks to do so. While you are wielding the item, it can’t be (action: Disarmed | Disarm) and you can’t drop or (action: Release) it; you must (action: Interact) to store the weapon and free that hand. A creature determined to retrieve the item can do so, but it requires either 1 minute to remove it or extreme violence to your arm—such as physically removing portions of the limb. You can only have one integrated armament at a time, though you can use the 1-minute activity to replace the item or swap the arm in which it’s stored." };
            yield return new TextBlock { Id = Guid.Parse("52e18b98-8eef-4f02-84ff-5798b857819f"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("6b13c214-03d1-49a2-ad39-9a5eb8146022"), Type = TextBlockType.Text, Text = "~ Enhancement: Your body has more space for integration. You can now either integrate two one-handed weapons, a one-handed weapon and a shield, or a single two-handed weapon which is split across both arms. You can use a single (action: Interact) action to draw or store both integrated armaments. When you draw a single weapon, you can choose to hold it with either one hand or both hands." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b5b919e6-4681-4676-8fa8-457b83137ceb"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
