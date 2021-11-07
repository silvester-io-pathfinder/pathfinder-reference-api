using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GnomeWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("bd1f88b9-d663-43c3-984d-1df5deded249");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gnome Weapon Familiarity",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f710d8e4-11a1-4400-b781-82922352c10b"), Type = TextBlockType.Text, Text = "You favor unusual weapons tied to your people, such as blades with curved and peculiar shapes. You are trained with the glaive and kukri." };
            yield return new TextBlock { Id = Guid.Parse("de9c8893-f8f3-49b9-b627-b0d813aba548"), Type = TextBlockType.Text, Text = "In addition, you gain access to all uncommon gnome weapons. For the purpose of determining your proficiency, martial gnome weapons are simple weapons and advanced gnome weapons are martial weapons." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d4733d85-4300-4444-99f6-0753a5242980"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
