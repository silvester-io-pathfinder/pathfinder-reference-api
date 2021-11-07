using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GAWayOfTheDrifter : Template
    {
        public static readonly Guid ID = Guid.Parse("348b83fe-c93a-4162-8ffd-37a1f2bba3f7");

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
            yield return new TextBlock { Id = Guid.Parse("8f86f305-3bf5-41e0-af0c-b3168771a4da"), Type = TextBlockType.Text, Text = "You’re a wanderer traveling from land to land with your gun and a melee weapon as company. Maybe you learned to fight with blade and pistol as a Shackles pirate, mastered the hand cannon and katana in Minkai, or practiced with a hatchet and clan pistol in Dongun Hold. You win battles by relying on mobility and flexible use of your weapons." };
            yield return new TextBlock { Id = Guid.Parse("7a55e294-d98c-4975-9804-29a9bca02d7d"), Type = TextBlockType.Text, Text = "~ Slinger&#39;s Reload: (feat: Reloading Strike)" };
            yield return new TextBlock { Id = Guid.Parse("291b5e7a-687b-45c5-9769-22b8cc35cf5a"), Type = TextBlockType.Text, Text = "~ Deeds: __Initial__ (feat: Into the Fray); __Advanced__ (feat: Finish the Job); __Greater__ (feat: Drifter’s Wake)" };
            yield return new TextBlock { Id = Guid.Parse("39099aca-3818-4d00-b726-938e80f93e56"), Type = TextBlockType.Text, Text = "~ Way Skill: Acrobatics" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d5996129-0487-42ed-8e61-4b0bec9501c8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
