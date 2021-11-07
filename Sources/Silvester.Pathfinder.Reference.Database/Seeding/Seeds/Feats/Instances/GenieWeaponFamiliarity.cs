using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GenieWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("98f76e06-54e7-4f51-9b94-65f21646d4cb");

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
            yield return new TextBlock { Id = Guid.Parse("2a9c68a2-fe7c-4650-8c68-da0ab69d5859"), Type = TextBlockType.Text, Text = "You’ve trained with weapons used by your genie ancestors. You are trained with (item: falchions | falchion), (item: ranseurs | ranseur), (item: scimitars | scimitar), and (item: tridents | trident). In addition, you gain access to all uncommon geniekin weapons. For the purpose of determining your proficiency, martial geniekin weapons are simple weapons and advanced geniekin weapons are martial weapons." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("64c3b1ca-c736-4741-a4aa-359f96ccd40e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
