using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RadiantBladeMaster : Template
    {
        public static readonly Guid ID = Guid.Parse("b7bc46e1-2a8d-45b4-8421-230106bfb050");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Radiant Blade Master",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6ca7bce6-6bf2-4a27-95ac-5e890cbf094d"), Type = TextBlockType.Text, Text = $"Your divine ally turns your chosen weapon into a paragon of its type. When you choose the weapon for your blade divine ally during your preparations, add the following property runes to the list of effects you can choose from: {ToMarkdownLink<Models.Items.Instances.WeaponPropertyRune>("dancing", Items.WeaponPropertyRunes.Instances.Dancing.ID)}, {ToMarkdownLink<Models.Items.Instances.WeaponPropertyRune>("greater disrupting", Items.WeaponPropertyRunes.Instances.Disrupting.ID)}, and {ToMarkdownLink<Models.Items.Instances.WeaponPropertyRune>("keen", Items.WeaponPropertyRunes.Instances.Keen.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("4f27a6a3-e406-4613-956b-2fd26a377928"), DivineAllies.Instances.Blade.ID);
            builder.HaveSpecificFeat(Guid.Parse("310ded48-ac38-4e3d-b36d-64ec22fb3952"), Feats.Instances.RadiantBladeSpirit.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("00e2389e-3d4c-4781-9e86-d57deaf0f5b2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
