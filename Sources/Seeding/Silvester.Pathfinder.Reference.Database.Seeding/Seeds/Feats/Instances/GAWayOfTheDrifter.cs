using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GAWayOfTheDrifter : Template
    {
        public static readonly Guid ID = Guid.Parse("4f61348e-31ad-4b27-8ce0-3232a96d0014");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "GA - Way of the Drifter",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d4546a99-7d71-4645-8017-3eb897864d9a"), Type = TextBlockType.Text, Text = "You’re a wanderer traveling from land to land with your gun and a melee weapon as company. Maybe you learned to fight with blade and pistol as a Shackles pirate, mastered the hand cannon and katana in Minkai, or practiced with a hatchet and clan pistol in Dongun Hold. You win battles by relying on mobility and flexible use of your weapons." };
            yield return new TextBlock { Id = Guid.Parse("1b453487-09fd-43ba-9487-58664276d40b"), Type = TextBlockType.Text, Text = "~ Slinger&#39;s Reload: (feat: Reloading Strike)" };
            yield return new TextBlock { Id = Guid.Parse("63057192-5322-40df-84e8-ed030bfb2141"), Type = TextBlockType.Text, Text = "~ Deeds: __Initial__ (feat: Into the Fray); __Advanced__ (feat: Finish the Job); __Greater__ (feat: Drifter’s Wake)" };
            yield return new TextBlock { Id = Guid.Parse("6e772dfd-e474-43dc-a753-14f03c5a04ff"), Type = TextBlockType.Text, Text = "~ Way Skill: Acrobatics" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eae39e3e-3a0c-4490-9876-41524a160e73"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
