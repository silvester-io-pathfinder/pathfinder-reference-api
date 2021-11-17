using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GenieWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("763bc92e-ea29-43e3-b384-d011a20db889");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Genie Weapon Familiarity",
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
            yield return new TextBlock { Id = Guid.Parse("29d9bfca-799a-4987-9887-57f3644bd5e8"), Type = TextBlockType.Text, Text = "You’ve trained with weapons used by your genie ancestors. You are trained with (item: falchions | falchion), (item: ranseurs | ranseur), (item: scimitars | scimitar), and (item: tridents | trident). In addition, you gain access to all uncommon geniekin weapons. For the purpose of determining your proficiency, martial geniekin weapons are simple weapons and advanced geniekin weapons are martial weapons." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("09c05321-e273-46b1-bb26-871e505fdf0d"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
