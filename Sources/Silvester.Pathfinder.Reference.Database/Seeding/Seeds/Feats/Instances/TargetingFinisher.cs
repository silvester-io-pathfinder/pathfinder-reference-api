using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TargetingFinisher : Template
    {
        public static readonly Guid ID = Guid.Parse("3c74e3e8-0980-4777-bcdb-2507302cfc15");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Targeting Finisher",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("640de6f5-e696-4410-bea8-b7c679500760"), Type = TextBlockType.Text, Text = "Your attack harms and hinders your foe. Choose a particular part of your foe from the list below and (action: Strike). If you hit and damage the target, apply the effect corresponding to the chosen part. This hindrance lasts until the end of your next turn. On a critical hit, you also apply a lesser effect lasting for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("d3bc60f2-d542-4fcd-a919-b9a3442c36cc"), Type = TextBlockType.Enumeration, Text = " Arm (or another limb used for attacks, such as a tentacle): The target is enfeebled 2. On a critical hit, it is also enfeebled 1 for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("a0c62ba5-85a1-421e-87ca-50059ecd62a8"), Type = TextBlockType.Enumeration, Text = " Head: The target is stupefied 2. On a critical hit, it is also stupefied 1 for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("f9781a30-a934-4efd-9e7b-d6166510609e"), Type = TextBlockType.Enumeration, Text = " Legs: The target takes a -10-foot status penalty to its Speeds. On a critical hit, it also takes a -5-foot status penalty to its Speeds for 1 minute." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4bab9dd8-2d41-408f-9fdc-0b0d816831a5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
