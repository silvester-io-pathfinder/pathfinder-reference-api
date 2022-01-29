using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpinningCrush : Template
    {
        public static readonly Guid ID = Guid.Parse("6194054f-a255-4db0-8c96-7210b66ad3d5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spinning Crush",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("220d75db-5e24-4fe6-9c48-9aa180c58baa"), Type = TextBlockType.Text, Text = $"You go into a vicious spin, smashing your weapon into those nearby and increasing your momentum by firing. All creatures adjacent to you take 1d6 bludgeoning damage plus your Strength modifier; this increases to 2d6 if your firearm has a {ToMarkdownLink<Models.Items.Instances.FundamentalWeaponRune>("striking rune", Items.FundamentalWeaponRunes.Instances.Striking.ID)}, 3d6 if it has a {ToMarkdownLink<Models.Items.Instances.FundamentalWeaponRune>("greater striking rune", Items.FundamentalWeaponRunes.Instances.Striking.ID)}, and 4d6 if it has a {ToMarkdownLink<Models.Items.Instances.FundamentalWeaponRune>("major striking rune", Items.FundamentalWeaponRunes.Instances.Striking.ID)}. This ability does not apply other effects that increase damage with your firearm {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} such as weapon specialization. Creatures affected by this attack must attempt a basic Reflex save. A creature that fails its save is also pushed 5 feet directly away from you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c835f96d-8d17-4f8f-b18e-aa938559cdea"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
